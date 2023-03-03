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
            this.components = new System.ComponentModel.Container();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddModelsID = new System.Windows.Forms.TextBox();
            this.AddModelsPN = new System.Windows.Forms.TextBox();
            this.AddModelsIDLabel = new System.Windows.Forms.Label();
            this.AddModelsPNLabel = new System.Windows.Forms.Label();
            this.BtAddNewModel = new System.Windows.Forms.Button();
            this.BarcodePreview = new System.Windows.Forms.PictureBox();
            this.BtPreview = new System.Windows.Forms.Button();
            this.BtPrint = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.BtRefreshButton = new System.Windows.Forms.Button();
            this.modelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btDelete = new System.Windows.Forms.Button();
            this.ModelsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddModelsID
            // 
            this.AddModelsID.Location = new System.Drawing.Point(12, 362);
            this.AddModelsID.Name = "AddModelsID";
            this.AddModelsID.Size = new System.Drawing.Size(254, 23);
            this.AddModelsID.TabIndex = 1;
            this.AddModelsID.Text = " ";
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
            // BtAddNewModel
            // 
            this.BtAddNewModel.Location = new System.Drawing.Point(272, 361);
            this.BtAddNewModel.Name = "BtAddNewModel";
            this.BtAddNewModel.Size = new System.Drawing.Size(84, 68);
            this.BtAddNewModel.TabIndex = 5;
            this.BtAddNewModel.Text = "Add New Model";
            this.BtAddNewModel.UseVisualStyleBackColor = true;
            this.BtAddNewModel.Click += new System.EventHandler(this.BtAddNewModel_Click);
            // 
            // BarcodePreview
            // 
            this.BarcodePreview.Location = new System.Drawing.Point(12, 12);
            this.BarcodePreview.Name = "BarcodePreview";
            this.BarcodePreview.Size = new System.Drawing.Size(349, 93);
            this.BarcodePreview.TabIndex = 6;
            this.BarcodePreview.TabStop = false;
            // 
            // BtPreview
            // 
            this.BtPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtPreview.Location = new System.Drawing.Point(272, 195);
            this.BtPreview.Name = "BtPreview";
            this.BtPreview.Size = new System.Drawing.Size(84, 34);
            this.BtPreview.TabIndex = 7;
            this.BtPreview.Text = "Preview";
            this.BtPreview.UseVisualStyleBackColor = true;
            this.BtPreview.Click += new System.EventHandler(this.BtPreview_Click);
            // 
            // BtPrint
            // 
            this.BtPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtPrint.Location = new System.Drawing.Point(12, 241);
            this.BtPrint.Name = "BtPrint";
            this.BtPrint.Size = new System.Drawing.Size(344, 85);
            this.BtPrint.TabIndex = 8;
            this.BtPrint.Text = "Print";
            this.BtPrint.UseVisualStyleBackColor = true;
            this.BtPrint.Click += new System.EventHandler(this.BtPrint_Click);
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
            // BtRefreshButton
            // 
            this.BtRefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtRefreshButton.Location = new System.Drawing.Point(272, 111);
            this.BtRefreshButton.Name = "BtRefreshButton";
            this.BtRefreshButton.Size = new System.Drawing.Size(84, 27);
            this.BtRefreshButton.TabIndex = 11;
            this.BtRefreshButton.Text = "Refresh";
            this.BtRefreshButton.UseVisualStyleBackColor = true;
            this.BtRefreshButton.Click += new System.EventHandler(this.BtRefreshButton_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDelete.Location = new System.Drawing.Point(272, 144);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 26);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // ModelsComboBox
            // 
            this.ModelsComboBox.DisplayMember = "MyModel";
            this.ModelsComboBox.FormattingEnabled = true;
            this.ModelsComboBox.Location = new System.Drawing.Point(12, 130);
            this.ModelsComboBox.Name = "ModelsComboBox";
            this.ModelsComboBox.Size = new System.Drawing.Size(254, 23);
            this.ModelsComboBox.TabIndex = 13;
            this.ModelsComboBox.ValueMember = "MyPartNum";
            this.ModelsComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelsComboBox_SelectedIndexChanged);
            // 
            // BarcodeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.ModelsComboBox);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.BtRefreshButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.BtPrint);
            this.Controls.Add(this.BtPreview);
            this.Controls.Add(this.BarcodePreview);
            this.Controls.Add(this.BtAddNewModel);
            this.Controls.Add(this.AddModelsPNLabel);
            this.Controls.Add(this.AddModelsIDLabel);
            this.Controls.Add(this.AddModelsPN);
            this.Controls.Add(this.AddModelsID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BarcodeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeApp";
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AddModelsID;
        private TextBox AddModelsPN;
        private Label AddModelsIDLabel;
        private Label AddModelsPNLabel;
        private Button BtAddNewModel;
        private PictureBox BarcodePreview;
        private Button BtPreview;
        private Button BtPrint;
        private TextBox QuantityBox;
        private Label QuantityLabel;
        private Button BtRefreshButton;
        private BindingSource modelBindingSource;
        private BindingSource modelBindingSource1;
        private Button btDelete;
        private ComboBox ModelsComboBox;
    }
}