using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_Cleaner
{
    class HelperMethods 
    {
        /// <summary>
        /// a helper method to get all the list of the a given the listbox contents
        /// is used to make a copy of the listbox contents to avoid iterating the listbox contents and modifying it
        /// </summary>
        /// <param name="list_box_contents">list of strings</param>
        /// <returns></returns>
        public List<string> get_items_from_list_box(ListBox.ObjectCollection list_box_contents)
        {

            List<string> list_of_files = new List<string>();
            foreach (string item in list_box_contents)
            {
                list_of_files.Add(item);
            }
            return list_of_files;
        }

        public void clear_items_from_listbox(ListBox.ObjectCollection files, StringBuilder error_message)
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
                catch
                {
                    error_message.Append($"\n {file}");

                }


            }

            foreach (string file in files_to_be_deleted)
            {
                
                files.Remove(file);
            }

            if (!String.IsNullOrWhiteSpace(error_message.ToString()))
            {
                MessageBox.Show(error_message.ToString());
            }
        }


    }
}
