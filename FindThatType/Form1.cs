using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace FindThatType
{
    public partial class FindThatType : Form
    {
        public FindThatType()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_browser_dialog = new FolderBrowserDialog();
            folder_browser_dialog.SelectedPath = "c:\\";
            if (folder_browser_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text  = folder_browser_dialog.SelectedPath;
            }
        }

        private void btnLoadLibs_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(txtPath.Text);
                try
                {
                    IEnumerable<FileInfo> all_files = directory.EnumerateFiles("*.dll", SearchOption.TopDirectoryOnly);
                
                    // prepare a list of files to try and load 
                    // create a separate list so can remove them when a load succeeds
                    List<FileInfo> files_to_try = new List<FileInfo>();
                    foreach (FileInfo file in all_files)
                    {
                        files_to_try.Add(file);
                    }


                    List<AnalysedAssembly> analysed_assemblies = new List<AnalysedAssembly>();
                    int assemblies_failed_in_pass = 0;
                    int fail_count = 0;
                    while (files_to_try.Count > 0 && fail_count < 20)
                    {
                        //unsure as to whether this code helps, but it doesn't hinder (except speed)
                        if (assemblies_failed_in_pass >= files_to_try.Count)
                        {
                            // have tried all the assemblies in the list 
                            //go round again
                            assemblies_failed_in_pass = 0;
                            fail_count++;
                        }
                        //pick up the next file to try
                        FileInfo file = files_to_try[assemblies_failed_in_pass];
                        try
                        {
                            //attempt analysis on the file 
                            analysed_assemblies.Add(AnalyseAssembly(file));
                            //if successful remove the analysed file from the list to try
                            files_to_try.Remove(file);
                        }
                        catch (Exception)
                        {
                            // unsuccessful analysis so increment the number tried 
                            assemblies_failed_in_pass++;

                        }
                    }
                    if (files_to_try.Count > 0)
                    {
                        MessageBox.Show("failed to load the following assemblies");
                        foreach (FileInfo f in files_to_try)
                        {
                            MessageBox.Show(f.FullName);
                        }
                    }
                    lstLibs.DisplayMember = "Path";
                    lstLibs.Items.AddRange(analysed_assemblies.ToArray());
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure path is valid");
            }
        }
        private static AnalysedAssembly AnalyseAssembly(FileInfo file)
        {
            Assembly assembly = Assembly.LoadFrom(file.FullName);
            //IEnumerable<Type> exported_types = assembly.GetExportedTypes();
            return new AnalysedAssembly(file.FullName, assembly.GetExportedTypes());
        }

        private void lstLibs_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstTypes.Items.Clear();
            lstTypes.Items.AddRange(((AnalysedAssembly)lstLibs.SelectedItem).Types.ToArray()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Hit> hits = new List<Hit>();
            lstHits.Items.Clear();
            string token = textBox1.Text;
            foreach (AnalysedAssembly assembly in lstLibs.Items)
            {
                foreach (Type type in assembly.Types)
                {
                    if (chkCase.Checked)
                    {//case sensitive
                        if (type.Name.Contains(token))
                        {
                            hits.Add(new Hit(assembly.Path, type));
                        }
                    }
                    else
                    {//insensitive
                        if (type.Name.ToLower().Contains(token.ToLower()))
                        {
                            hits.Add(new Hit(assembly.Path, type));
                        }
                    }
                }
            }
            lstHits.Items.AddRange(hits.ToArray());
        }
        
    }

}
