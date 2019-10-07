namespace Itse1430.MovieLib.Host
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.chkHasSeen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this._txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(124, 61);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(525, 26);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // chkHasSeen
            // 
            this.chkHasSeen.AutoSize = true;
            this.chkHasSeen.Location = new System.Drawing.Point(124, 125);
            this.chkHasSeen.Name = "chkHasSeen";
            this.chkHasSeen.Size = new System.Drawing.Size(115, 24);
            this.chkHasSeen.TabIndex = 3;
            this.chkHasSeen.Text = "Has Seen?";
            this.chkHasSeen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Release Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rating";
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.cbRating.Location = new System.Drawing.Point(124, 155);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(180, 28);
            this.cbRating.TabIndex = 4;
            this.cbRating.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRating);
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(124, 93);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(180, 26);
            this._txtReleaseYear.TabIndex = 2;
            this._txtReleaseYear.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingReleaseYear);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Run Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(124, 189);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(180, 26);
            this._txtRunLength.TabIndex = 5;
            this._txtRunLength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRunLength);
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(383, 123);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(266, 234);
            this._txtDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(493, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(574, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(678, 429);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtReleaseYear);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHasSeen);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 485);
            this.Name = "MovieForm";
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.CheckBox chkHasSeen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.TextBox _txtReleaseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}