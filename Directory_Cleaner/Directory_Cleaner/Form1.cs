using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// searches all the files in the given file path on 
        /// file_path_texbox and appends all found files to files_list listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            
            string file_path = file_path_textbox.Text;
            var included_file_extensions = file_extensions_to_include.Items;
            List<string> file_extensions = new HelperMethods().get_items_from_list_box(included_file_extensions);//get_items_from_list_box(included_file_extensions);
            
            if (Directory.Exists(file_path))
            {
                files_list.Items.Clear();
                string[] files = Directory.GetFiles(file_path);
                files_found.Text = $"{files.Count().ToString()} files found";
                bool has_file_extensions = file_extensions_to_include.Items.Count > 0;
                if (has_file_extensions)
                {
                    foreach (string file in files)
                    {
                        foreach (string file_extension in file_extensions)
                        {
                            if (file.EndsWith(file_extension))
                            {
                                files_list.Items.Add(file);
                            }
                        }
                    }
                }
                
                else
                {
                    foreach(string file in files)
                    {
                        files_list.Items.Add(file);
                    }
                }

                files_found.Text = $"{files_list.Items.Count} files found";
            }

        }


        /// <summary>
        /// clears the file_path_textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            file_path_textbox.Clear();
        }


        /// <summary>
        /// adds a filter to the file_extensions_to_include listbox
        /// this will help narrow down the files to show on the files_list_box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_filter_Click(object sender, EventArgs e)
        {
            string file_extension = file_extension_textbox.Text;
            if(!String.IsNullOrWhiteSpace(file_extension))
            {
                file_extensions_to_include.Items.Add(file_extension);
                file_extension_textbox.Clear();
            }
            
        }


        /// <summary>
        /// clears the list extensions highlighed/selected on the file_extensions_to_include listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_selected_extension_Click(object sender, EventArgs e)
        {
            bool has_selected_an_extension = file_extensions_to_include.SelectedItems.Count != 0;
            bool has_file_extensions = file_extensions_to_include.Items.Count != 0;

            if(has_selected_an_extension)
            {
                List<string> items_to_remove = new List<string>();
                var selected_extensions = file_extensions_to_include.SelectedItems;

                foreach (string extension in selected_extensions)
                {
                    items_to_remove.Add(extension);
                }

                foreach (string item in items_to_remove)
                {
                    file_extensions_to_include.Items.Remove(item);
                }
            }

            else if(has_file_extensions && !has_selected_an_extension)
            {
                MessageBox.Show("you did not select any filters to remove",
                               "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2);
            }
        }


        /// <summary>
        /// clears all the items in the file_extensions_to_include listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_all_extensions_Click(object sender, EventArgs e)
        {
            file_extensions_to_include.Items.Clear();
        }


        /// <summary>
        /// deletes all selected/highlighted files in the files_list listbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_selected_files_Click(object sender, EventArgs e)
        {
            bool file_extensions = file_extensions_to_include.Items.Count == 0;
            bool files_list_selected_items = files_list.SelectedItems.Count == 0;
            bool files_list_count = files_list.Items.Count == 0;
            var files = files_list.Items;
            StringBuilder error_message = new StringBuilder();

            if (!files_list_selected_items)
            {
                
                List<string> files_to_be_deleted = new List<string>();
                var files_selected = files_list.SelectedItems;
                List<string> undeleted_files = new List<string>();
                foreach (string file in files_selected)
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                        files_to_be_deleted.Add(file);  
                    }

                    catch
                    {
                        error_message.Append($"\n{file}");
                    }
                }

                foreach (string file in files_to_be_deleted)
                {
                    files_list.Items.Remove(file);
                }


                if (!String.IsNullOrWhiteSpace(error_message.ToString()))
                {
                    MessageBox.Show($" the following files could not be deleted {error_message.ToString()} ");
                }

                files_found.Text = $"{files_list.Items.Count} files found";
            }

            else if(files_list_selected_items && !files_list_count)
            {
                MessageBox.Show("you did not select any files",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
            }    
        }

        /// <summary>
        /// clears all the files in the files_list. list box and deletes all listed files from the given directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_all_files_Click(object sender, EventArgs e)
        {
           
            bool file_extensions = file_extensions_to_include.Items.Count == 0;
            bool files_list_count = files_list.Items.Count == 0;
            var files = files_list.Items;
            StringBuilder error_message = new StringBuilder();
            if (!file_extensions && !files_list_count)
            {
                List<string> files_to_be_deleted = new List<string>();/**get_items_from_list_box(files);**/
                foreach (string file in files)
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                        files_to_be_deleted.Add(file);
                    }
                    catch { error_message.Append($"\n {file}");} 
                }

                foreach(string file in files_to_be_deleted)
                {
                    files.Remove(file);
                }

                if(!String.IsNullOrWhiteSpace(error_message.ToString()))
                {
                    MessageBox.Show($" the following files could not be deleted {error_message.ToString()} ");
                } 
                
            }

            else if(!files_list_count && file_extensions)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete all the contents of this folder?",
                                                       "Warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question,
                                                       MessageBoxDefaultButton.Button2);
                if(result == DialogResult.Yes)
                {
                    List<string> files_to_be_deleted = new List<string>();/**get_items_from_list_box(files);**/
                    foreach (string file in files)
                    {
                        try
                        {
                            File.SetAttributes(file, FileAttributes.Normal);
                            File.Delete(file);
                            files_to_be_deleted.Add(file);
                        }
                        catch { error_message.Append($"\n {file}"); }
                    }

                    foreach(string file in files_to_be_deleted)
                    {
                        files_list.Items.Remove(file);
                    }

                    if (!String.IsNullOrWhiteSpace(error_message.ToString()))
                    {
                        MessageBox.Show(error_message.ToString());
                    }
                }
            }
            files_found.Text = "0 files found";
        }

        
        /// <summary>
        /// clears the result of the of the files_list list box. only clears it no actually delete the files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_files_list_Click(object sender, EventArgs e)
        {
            files_list.Items.Clear();
            files_found.Text = "0 files found";
        }


        /// <summary>
        /// when the file_extension_textbox is in focus and the user presses enter
        /// the text in the file_extension_textbox will be added in the file_extensions_to_include
        /// list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void file_extension_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(file_extension_textbox.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    add_filter_Click(this, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }            

        }

        /// <summary>
        /// when the file_path_textbox is n focus and the user clicks enter
        /// the search_Click method will be fired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void file_path_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(!String.IsNullOrWhiteSpace(file_path_textbox.Text))
            {
                if(e.KeyCode == Keys.Enter)
                {
                    search_Click(this, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }  
            }
        }    

        private void file_path_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(file_path_textbox.Text)){
                FolderBrowserDialog file_browser_dialog = new FolderBrowserDialog();
                file_browser_dialog.ShowDialog();
                file_path_textbox.Text = file_browser_dialog.SelectedPath;
            }

            else
            {
                file_path_textbox.SelectAll();
            }
            
        }
    }
}
