using System.Drawing;
using System.Windows.Forms;

namespace HW0103
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.subdirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.keyWordSearchTextBox = new System.Windows.Forms.TextBox();
            this.directoryComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.outputListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdAtHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по ключевому слову";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Диски";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(385, 20);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 19);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(467, 20);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(79, 19);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // subdirectoryCheckBox
            // 
            this.subdirectoryCheckBox.AutoSize = true;
            this.subdirectoryCheckBox.Location = new System.Drawing.Point(550, 20);
            this.subdirectoryCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subdirectoryCheckBox.Name = "subdirectoryCheckBox";
            this.subdirectoryCheckBox.Size = new System.Drawing.Size(92, 17);
            this.subdirectoryCheckBox.TabIndex = 5;
            this.subdirectoryCheckBox.Text = "Подкаталоги";
            this.subdirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(8, 21);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(85, 20);
            this.fileTextBox.TabIndex = 6;
            // 
            // keyWordSearchTextBox
            // 
            this.keyWordSearchTextBox.Location = new System.Drawing.Point(95, 20);
            this.keyWordSearchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyWordSearchTextBox.Name = "keyWordSearchTextBox";
            this.keyWordSearchTextBox.Size = new System.Drawing.Size(181, 20);
            this.keyWordSearchTextBox.TabIndex = 7;
            // 
            // directoryComboBox
            // 
            this.directoryComboBox.FormattingEnabled = true;
            this.directoryComboBox.Location = new System.Drawing.Point(279, 20);
            this.directoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directoryComboBox.Name = "directoryComboBox";
            this.directoryComboBox.Size = new System.Drawing.Size(103, 21);
            this.directoryComboBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(222, 50);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(111, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "результаты поиска: ";
            // 
            // outputListView
            // 
            this.outputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.pathHeader,
            this.sizeHeader,
            this.createdAtHeader});
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(8, 72);
            this.outputListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(736, 328);
            this.outputListView.TabIndex = 11;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Имя";
            this.nameHeader.Width = 200;
            // 
            // pathHeader
            // 
            this.pathHeader.Text = "Папка";
            this.pathHeader.Width = 400;
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "Размер";
            this.sizeHeader.Width = 150;
            // 
            // createdAtHeader
            // 
            this.createdAtHeader.Text = "Дата Модификации";
            this.createdAtHeader.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 406);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.directoryComboBox);
            this.Controls.Add(this.keyWordSearchTextBox);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.subdirectoryCheckBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button searchButton;
        private Button stopButton;
        private CheckBox subdirectoryCheckBox;
        private TextBox fileTextBox;
        private TextBox keyWordSearchTextBox;
        private ComboBox directoryComboBox;
        private Label resultLabel;
        private ListView outputListView;
        private ColumnHeader nameHeader;
        private ColumnHeader pathHeader;
        private ColumnHeader sizeHeader;
        private ColumnHeader createdAtHeader;
    }
}
