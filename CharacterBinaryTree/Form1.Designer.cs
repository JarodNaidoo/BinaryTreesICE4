namespace CharacterBinaryTree
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
            txtName = new TextBox();
            txtPower = new TextBox();
            txtSpeed = new TextBox();
            btnAddCharacter = new Button();
            lstCharacters = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPower
            // 
            txtPower.Location = new Point(12, 170);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(188, 23);
            txtPower.TabIndex = 1;
            txtPower.TextChanged += txtPower_TextChanged;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(12, 266);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(188, 23);
            txtSpeed.TabIndex = 2;
            txtSpeed.TextChanged += txtSpeed_TextChanged;
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.AutoSize = true;
            btnAddCharacter.BackColor = Color.FromArgb(128, 255, 255);
            btnAddCharacter.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnAddCharacter.FlatAppearance.BorderSize = 0;
            btnAddCharacter.FlatStyle = FlatStyle.Popup;
            btnAddCharacter.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddCharacter.ForeColor = Color.DimGray;
            btnAddCharacter.Location = new Point(320, 197);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(139, 27);
            btnAddCharacter.TabIndex = 3;
            btnAddCharacter.Text = "ADD CHARACTER";
            btnAddCharacter.UseVisualStyleBackColor = false;
            btnAddCharacter.Click += btnAddCharacter_Click;
            // 
            // lstCharacters
            // 
            lstCharacters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstCharacters.BackColor = SystemColors.InactiveCaption;
            lstCharacters.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCharacters.ForeColor = SystemColors.Info;
            lstCharacters.FormattingEnabled = true;
            lstCharacters.ItemHeight = 19;
            lstCharacters.Location = new Point(511, -1);
            lstCharacters.Name = "lstCharacters";
            lstCharacters.Size = new Size(290, 441);
            lstCharacters.TabIndex = 4;
            lstCharacters.SelectedIndexChanged += lstCharacters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(258, 19);
            label1.TabIndex = 5;
            label1.Text = "NAME YOUR CHARACTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(305, 19);
            label2.TabIndex = 6;
            label2.Text = "WHATS THE POWER LEVEL!!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 255, 255);
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(245, 19);
            label3.TabIndex = 7;
            label3.Text = "WHATS THE SPEEEED!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCharacters);
            Controls.Add(btnAddCharacter);
            Controls.Add(txtSpeed);
            Controls.Add(txtPower);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "StatFight";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPower;
        private TextBox txtSpeed;
        private Button btnAddCharacter;
        private ListBox lstCharacters;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
