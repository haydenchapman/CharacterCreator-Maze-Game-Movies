namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this._txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProfession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors2 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors3 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors4 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors5 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors6 = new System.Windows.Forms.ErrorProvider(this.components);
            this._errors7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors7)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this._txtName.Location = new System.Drawing.Point(107, 32);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(274, 26);
            this._txtName.TabIndex = 0;
            this._txtName.UseWaitCursor = true;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // cbProfession
            // 
            this.cbProfession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProfession.FormattingEnabled = true;
            this.cbProfession.Items.AddRange(new object[] {
            "Alchemist",
            "Hunter",
            "Mage",
            "Bandit",
            "Sailor"});
            this.cbProfession.Location = new System.Drawing.Point(107, 82);
            this.cbProfession.Name = "cbProfession";
            this.cbProfession.Size = new System.Drawing.Size(274, 28);
            this.cbProfession.TabIndex = 1;
            this.cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingPro);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profession";
            // 
            // cbRace
            // 
            this.cbRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "Human",
            "Android",
            "Dwarf",
            "Elf",
            "Orc"});
            this.cbRace.Location = new System.Drawing.Point(107, 136);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(274, 28);
            this.cbRace.TabIndex = 2;
            this.cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRace);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Attributes";
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(107, 187);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(274, 171);
            this._txtDescription.TabIndex = 3;
            this._txtDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(422, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(518, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(518, 117);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(100, 26);
            this._txtStrength.TabIndex = 4;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStrength);
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(518, 149);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(100, 26);
            this._txtIntelligence.TabIndex = 5;
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingIntelligence);
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(518, 181);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(100, 26);
            this._txtAgility.TabIndex = 6;
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAgility);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(518, 213);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(100, 26);
            this._txtConstitution.TabIndex = 7;
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingConstitution);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(518, 245);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(100, 26);
            this._txtCharisma.TabIndex = 8;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingCharisma);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Intelligence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Agility";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Charisma";
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // _errors1
            // 
            this._errors1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors1.ContainerControl = this;
            // 
            // _errors2
            // 
            this._errors2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors2.ContainerControl = this;
            // 
            // _errors3
            // 
            this._errors3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors3.ContainerControl = this;
            // 
            // _errors4
            // 
            this._errors4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors4.ContainerControl = this;
            // 
            // _errors5
            // 
            this._errors5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors5.ContainerControl = this;
            // 
            // _errors6
            // 
            this._errors6.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors6.ContainerControl = this;
            // 
            // _errors7
            // 
            this._errors7.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors7.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(671, 378);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProfession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "CharacterForm";
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProfession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox _txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.ErrorProvider _errors1;
        private System.Windows.Forms.ErrorProvider _errors2;
        private System.Windows.Forms.ErrorProvider _errors3;
        private System.Windows.Forms.ErrorProvider _errors4;
        private System.Windows.Forms.ErrorProvider _errors5;
        private System.Windows.Forms.ErrorProvider _errors6;
        private System.Windows.Forms.ErrorProvider _errors7;
    }
}