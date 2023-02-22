namespace BarcodeV2
{
    partial class BarcodeWindow
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
            this.ModelsListBox = new System.Windows.Forms.ListBox();
            this.AddModelsID = new System.Windows.Forms.TextBox();
            this.AddModelsPN = new System.Windows.Forms.TextBox();
            this.AddModelsIDLabel = new System.Windows.Forms.Label();
            this.AddModelsPNLabel = new System.Windows.Forms.Label();
            this.btAddNewModel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelsListBox
            // 
            this.ModelsListBox.FormattingEnabled = true;
            this.ModelsListBox.ItemHeight = 15;
            this.ModelsListBox.Location = new System.Drawing.Point(12, 138);
            this.ModelsListBox.Name = "ModelsListBox";
            this.ModelsListBox.Size = new System.Drawing.Size(254, 34);
            this.ModelsListBox.TabIndex = 0;
            this.ModelsListBox.SelectedIndexChanged += new System.EventHandler(this.ModelsListBox_SelectedIndexChanged);
            // 
            // AddModelsID
            // 
            this.AddModelsID.Location = new System.Drawing.Point(12, 362);
            this.AddModelsID.Name = "AddModelsID";
            this.AddModelsID.Size = new System.Drawing.Size(254, 23);
            this.AddModelsID.TabIndex = 1;
            // 
            // AddModelsPN
            // 
            this.AddModelsPN.Location = new System.Drawing.Point(12, 406);
            this.AddModelsPN.Name = "AddModelsPN";
            this.AddModelsPN.Size = new System.Drawing.Size(254, 23);
            this.AddModelsPN.TabIndex = 2;
            // 
            // AddModelsIDLabel
            // 
            this.AddModelsIDLabel.AutoSize = true;
            this.AddModelsIDLabel.Location = new System.Drawing.Point(12, 344);
            this.AddModelsIDLabel.Name = "AddModelsIDLabel";
            this.AddModelsIDLabel.Size = new System.Drawing.Size(87, 15);
            this.AddModelsIDLabel.TabIndex = 3;
            this.AddModelsIDLabel.Text = "Insert Model ID";
            this.AddModelsIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddModelsPNLabel
            // 
            this.AddModelsPNLabel.AutoSize = true;
            this.AddModelsPNLabel.Location = new System.Drawing.Point(12, 388);
            this.AddModelsPNLabel.Name = "AddModelsPNLabel";
            this.AddModelsPNLabel.Size = new System.Drawing.Size(92, 15);
            this.AddModelsPNLabel.TabIndex = 4;
            this.AddModelsPNLabel.Text = "Insert Model PN";
            this.AddModelsPNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAddNewModel
            // 
            this.btAddNewModel.Location = new System.Drawing.Point(272, 361);
            this.btAddNewModel.Name = "btAddNewModel";
            this.btAddNewModel.Size = new System.Drawing.Size(84, 68);
            this.btAddNewModel.TabIndex = 5;
            this.btAddNewModel.Text = "Add New Model";
            this.btAddNewModel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 93);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btPreview
            // 
            this.btPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPreview.Location = new System.Drawing.Point(272, 138);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(84, 34);
            this.btPreview.TabIndex = 7;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPrint.Location = new System.Drawing.Point(12, 241);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(344, 85);
            this.btPrint.TabIndex = 8;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(12, 202);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(254, 23);
            this.QuantityBox.TabIndex = 9;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(12, 184);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(85, 15);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Insert Quantity";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarcodeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddNewModel);
            this.Controls.Add(this.AddModelsPNLabel);
            this.Controls.Add(this.AddModelsIDLabel);
            this.Controls.Add(this.AddModelsPN);
            this.Controls.Add(this.AddModelsID);
            this.Controls.Add(this.ModelsListBox);
            this.Name = "BarcodeWindow";
            this.Text = "BarcodeApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ModelsListBox;
        private TextBox AddModelsID;
        private TextBox AddModelsPN;
        private Label AddModelsIDLabel;
        private Label AddModelsPNLabel;
        private Button btAddNewModel;
        private PictureBox pictureBox1;
        private Button btPreview;
        private Button btPrint;
        private TextBox QuantityBox;
        private Label QuantityLabel;
    }
}