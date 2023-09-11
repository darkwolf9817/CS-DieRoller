namespace CSDieRoller
{
    partial class frmMain
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
            label1 = new Label();
            label2 = new Label();
            nbxDieCount = new NumericUpDown();
            cbxDieType = new ComboBox();
            grpAbilityControls = new GroupBox();
            rdo3d6 = new RadioButton();
            rdo4d6 = new RadioButton();
            outBox = new ListBox();
            btnRoll = new Button();
            btnClear = new Button();
            btnAbility = new Button();
            ((System.ComponentModel.ISupportInitialize)nbxDieCount).BeginInit();
            grpAbilityControls.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Num Dice: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Die Type: ";
            // 
            // nbxDieCount
            // 
            nbxDieCount.Location = new Point(117, 7);
            nbxDieCount.Name = "nbxDieCount";
            nbxDieCount.Size = new Size(273, 31);
            nbxDieCount.TabIndex = 2;
            // 
            // cbxDieType
            // 
            cbxDieType.FormattingEnabled = true;
            cbxDieType.Items.AddRange(new object[] { "D20", "D12", "D10", "D8", "D6", "D4", "D100" });
            cbxDieType.Location = new Point(117, 58);
            cbxDieType.Name = "cbxDieType";
            cbxDieType.Size = new Size(273, 33);
            cbxDieType.TabIndex = 3;
            // 
            // grpAbilityControls
            // 
            grpAbilityControls.Controls.Add(rdo4d6);
            grpAbilityControls.Controls.Add(rdo3d6);
            grpAbilityControls.Location = new Point(471, 9);
            grpAbilityControls.Name = "grpAbilityControls";
            grpAbilityControls.Size = new Size(276, 137);
            grpAbilityControls.TabIndex = 4;
            grpAbilityControls.TabStop = false;
            grpAbilityControls.Text = "Ability Score Controls";
            // 
            // rdo3d6
            // 
            rdo3d6.AutoSize = true;
            rdo3d6.Location = new Point(6, 30);
            rdo3d6.Name = "rdo3d6";
            rdo3d6.Size = new Size(64, 29);
            rdo3d6.TabIndex = 0;
            rdo3d6.TabStop = true;
            rdo3d6.Text = "3d6";
            rdo3d6.UseVisualStyleBackColor = true;
            // 
            // rdo4d6
            // 
            rdo4d6.AutoSize = true;
            rdo4d6.Location = new Point(6, 90);
            rdo4d6.Name = "rdo4d6";
            rdo4d6.Size = new Size(64, 29);
            rdo4d6.TabIndex = 1;
            rdo4d6.TabStop = true;
            rdo4d6.Text = "4d6";
            rdo4d6.UseVisualStyleBackColor = true;
            // 
            // outBox
            // 
            outBox.FormattingEnabled = true;
            outBox.ItemHeight = 25;
            outBox.Location = new Point(12, 177);
            outBox.Name = "outBox";
            outBox.Size = new Size(1157, 129);
            outBox.TabIndex = 2;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(1064, 12);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(105, 41);
            btnRoll.TabIndex = 5;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1064, 58);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 41);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAbility
            // 
            btnAbility.Location = new Point(1064, 104);
            btnAbility.Name = "btnAbility";
            btnAbility.Size = new Size(105, 41);
            btnAbility.TabIndex = 7;
            btnAbility.Text = "Ability Roll";
            btnAbility.UseVisualStyleBackColor = true;
            btnAbility.Click += btnAbility_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 318);
            Controls.Add(btnAbility);
            Controls.Add(btnClear);
            Controls.Add(btnRoll);
            Controls.Add(outBox);
            Controls.Add(grpAbilityControls);
            Controls.Add(cbxDieType);
            Controls.Add(nbxDieCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMain";
            Text = "Die Roller";
            ((System.ComponentModel.ISupportInitialize)nbxDieCount).EndInit();
            grpAbilityControls.ResumeLayout(false);
            grpAbilityControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nbxDieCount;
        private ComboBox cbxDieType;
        private GroupBox grpAbilityControls;
        private RadioButton rdo4d6;
        private RadioButton rdo3d6;
        private ListBox outBox;
        private Button btnRoll;
        private Button btnClear;
        private Button btnAbility;
    }
}