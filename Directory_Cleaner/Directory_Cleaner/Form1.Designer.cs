namespace Directory_Cleaner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_path_textbox = new System.Windows.Forms.TextBox();
            this.directory_path = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.files_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_filter = new System.Windows.Forms.Button();
            this.file_extension_textbox = new System.Windows.Forms.TextBox();
            this.file_extensions = new System.Windows.Forms.Label();
            this.file_extensions_to_include = new System.Windows.Forms.ListBox();
            this.clear_all_extensions = new System.Windows.Forms.Button();
            this.clear_selected_extension = new System.Windows.Forms.Button();
            this.delete_selected_files = new System.Windows.Forms.Button();
            this.clear_all_files = new System.Windows.Forms.Button();
            this.files_found = new System.Windows.Forms.Label();
            this.clear_files_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file_path_textbox
            // 
            this.file_path_textbox.Location = new System.Drawing.Point(135, 44);
            this.file_path_textbox.Name = "file_path_textbox";
            this.file_path_textbox.Size = new System.Drawing.Size(406, 26);
            this.file_path_textbox.TabIndex = 0;
            this.file_path_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.file_path_textbox_KeyDown);
            this.file_path_textbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.file_path_textbox_MouseDoubleClick);
            // 
            // directory_path
            // 
            this.directory_path.AutoSize = true;
            this.directory_path.Location = new System.Drawing.Point(44, 44);
            this.directory_path.Name = "directory_path";
            this.directory_path.Size = new System.Drawing.Size(69, 20);
            this.directory_path.TabIndex = 1;
            this.directory_path.Text = "directory";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(135, 105);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(161, 49);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(376, 105);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(165, 49);
            this.clear.TabIndex = 3;
            this.clear.Text = "clear ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // files_list
            // 
            this.files_list.FormattingEnabled = true;
            this.files_list.ItemHeight = 20;
            this.files_list.Location = new System.Drawing.Point(623, 44);
            this.files_list.Name = "files_list";
            this.files_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.files_list.Size = new System.Drawing.Size(772, 604);
            this.files_list.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "filter";
            // 
            // add_filter
            // 
            this.add_filter.Location = new System.Drawing.Point(376, 435);
            this.add_filter.Name = "add_filter";
            this.add_filter.Size = new System.Drawing.Size(165, 50);
            this.add_filter.TabIndex = 7;
            this.add_filter.Text = "add";
            this.add_filter.UseVisualStyleBackColor = true;
            this.add_filter.Click += new System.EventHandler(this.add_filter_Click);
            // 
            // file_extension_textbox
            // 
            this.file_extension_textbox.Location = new System.Drawing.Point(135, 437);
            this.file_extension_textbox.Name = "file_extension_textbox";
            this.file_extension_textbox.Size = new System.Drawing.Size(204, 26);
            this.file_extension_textbox.TabIndex = 8;
            this.file_extension_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.file_extension_textbox_KeyDown);
            // 
            // file_extensions
            // 
            this.file_extensions.AutoSize = true;
            this.file_extensions.Location = new System.Drawing.Point(12, 437);
            this.file_extensions.Name = "file_extensions";
            this.file_extensions.Size = new System.Drawing.Size(101, 20);
            this.file_extensions.TabIndex = 9;
            this.file_extensions.Text = "file extension";
            // 
            // file_extensions_to_include
            // 
            this.file_extensions_to_include.FormattingEnabled = true;
            this.file_extensions_to_include.ItemHeight = 20;
            this.file_extensions_to_include.Location = new System.Drawing.Point(135, 222);
            this.file_extensions_to_include.Name = "file_extensions_to_include";
            this.file_extensions_to_include.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.file_extensions_to_include.Size = new System.Drawing.Size(406, 164);
            this.file_extensions_to_include.TabIndex = 10;
            // 
            // clear_all_extensions
            // 
            this.clear_all_extensions.Location = new System.Drawing.Point(376, 510);
            this.clear_all_extensions.Name = "clear_all_extensions";
            this.clear_all_extensions.Size = new System.Drawing.Size(165, 51);
            this.clear_all_extensions.TabIndex = 11;
            this.clear_all_extensions.Text = "clear all";
            this.clear_all_extensions.UseVisualStyleBackColor = true;
            this.clear_all_extensions.Click += new System.EventHandler(this.clear_all_extensions_Click);
            // 
            // clear_selected_extension
            // 
            this.clear_selected_extension.Location = new System.Drawing.Point(135, 510);
            this.clear_selected_extension.Name = "clear_selected_extension";
            this.clear_selected_extension.Size = new System.Drawing.Size(204, 51);
            this.clear_selected_extension.TabIndex = 12;
            this.clear_selected_extension.Text = "clear selected extensions";
            this.clear_selected_extension.UseVisualStyleBackColor = true;
            this.clear_selected_extension.Click += new System.EventHandler(this.clear_selected_extension_Click);
            // 
            // delete_selected_files
            // 
            this.delete_selected_files.Location = new System.Drawing.Point(623, 670);
            this.delete_selected_files.Name = "delete_selected_files";
            this.delete_selected_files.Size = new System.Drawing.Size(230, 53);
            this.delete_selected_files.TabIndex = 13;
            this.delete_selected_files.Text = "delete selected files ";
            this.delete_selected_files.UseVisualStyleBackColor = true;
            this.delete_selected_files.Click += new System.EventHandler(this.delete_selected_files_Click);
            // 
            // clear_all_files
            // 
            this.clear_all_files.Location = new System.Drawing.Point(895, 670);
            this.clear_all_files.Name = "clear_all_files";
            this.clear_all_files.Size = new System.Drawing.Size(233, 53);
            this.clear_all_files.TabIndex = 14;
            this.clear_all_files.Text = "delete all files";
            this.clear_all_files.UseVisualStyleBackColor = true;
            this.clear_all_files.Click += new System.EventHandler(this.clear_all_files_Click);
            // 
            // files_found
            // 
            this.files_found.AutoSize = true;
            this.files_found.Location = new System.Drawing.Point(619, 21);
            this.files_found.Name = "files_found";
            this.files_found.Size = new System.Drawing.Size(95, 20);
            this.files_found.TabIndex = 15;
            this.files_found.Text = "0 files found";
            // 
            // clear_files_list
            // 
            this.clear_files_list.Location = new System.Drawing.Point(1172, 670);
            this.clear_files_list.Name = "clear_files_list";
            this.clear_files_list.Size = new System.Drawing.Size(223, 53);
            this.clear_files_list.TabIndex = 16;
            this.clear_files_list.Text = "clear";
            this.clear_files_list.UseVisualStyleBackColor = true;
            this.clear_files_list.Click += new System.EventHandler(this.clear_files_list_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 747);
            this.Controls.Add(this.clear_files_list);
            this.Controls.Add(this.files_found);
            this.Controls.Add(this.clear_all_files);
            this.Controls.Add(this.delete_selected_files);
            this.Controls.Add(this.clear_selected_extension);
            this.Controls.Add(this.clear_all_extensions);
            this.Controls.Add(this.file_extensions_to_include);
            this.Controls.Add(this.file_extensions);
            this.Controls.Add(this.file_extension_textbox);
            this.Controls.Add(this.add_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.files_list);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.directory_path);
            this.Controls.Add(this.file_path_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_path_textbox;
        private System.Windows.Forms.Label directory_path;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListBox files_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_filter;
        private System.Windows.Forms.TextBox file_extension_textbox;
        private System.Windows.Forms.Label file_extensions;
        private System.Windows.Forms.ListBox file_extensions_to_include;
        private System.Windows.Forms.Button clear_all_extensions;
        private System.Windows.Forms.Button clear_selected_extension;
        private System.Windows.Forms.Button delete_selected_files;
        private System.Windows.Forms.Button clear_all_files;
        private System.Windows.Forms.Label files_found;
        private System.Windows.Forms.Button clear_files_list;
    }
}

