namespace Roll
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox rollingCountDisplay;
            System.Windows.Forms.GroupBox groupBoxOperation;
            System.Windows.Forms.GroupBox attributesDisplay;
            System.Windows.Forms.GroupBox commandDisplay;
            this.rollingCount = new System.Windows.Forms.NumericUpDown();
            this.emptyButton = new System.Windows.Forms.Button();
            this.executingButton = new System.Windows.Forms.Button();
            this.checkIfSumOnly = new System.Windows.Forms.CheckBox();
            this.checkIfAddValue = new System.Windows.Forms.CheckBox();
            this.command = new System.Windows.Forms.TextBox();
            this.rollingValueDisplay = new System.Windows.Forms.GroupBox();
            this.rollingValue = new System.Windows.Forms.TextBox();
            this.rollingResultDisplay = new System.Windows.Forms.GroupBox();
            this.rollingResult = new System.Windows.Forms.Label();
            this.resultsList = new System.Windows.Forms.ListBox();
            rollingCountDisplay = new System.Windows.Forms.GroupBox();
            groupBoxOperation = new System.Windows.Forms.GroupBox();
            attributesDisplay = new System.Windows.Forms.GroupBox();
            commandDisplay = new System.Windows.Forms.GroupBox();
            rollingCountDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollingCount)).BeginInit();
            groupBoxOperation.SuspendLayout();
            attributesDisplay.SuspendLayout();
            commandDisplay.SuspendLayout();
            this.rollingValueDisplay.SuspendLayout();
            this.rollingResultDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollingCountDisplay
            // 
            rollingCountDisplay.Controls.Add(this.rollingCount);
            rollingCountDisplay.Location = new System.Drawing.Point(76, 119);
            rollingCountDisplay.Name = "rollingCountDisplay";
            rollingCountDisplay.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            rollingCountDisplay.Size = new System.Drawing.Size(83, 62);
            rollingCountDisplay.TabIndex = 3;
            rollingCountDisplay.TabStop = false;
            rollingCountDisplay.Text = "个数";
            // 
            // rollingCount
            // 
            this.rollingCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingCount.Location = new System.Drawing.Point(10, 23);
            this.rollingCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rollingCount.Name = "rollingCount";
            this.rollingCount.Size = new System.Drawing.Size(63, 25);
            this.rollingCount.TabIndex = 0;
            this.rollingCount.Tag = "count";
            this.rollingCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rollingCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxOperation
            // 
            groupBoxOperation.Controls.Add(this.emptyButton);
            groupBoxOperation.Controls.Add(this.executingButton);
            groupBoxOperation.Location = new System.Drawing.Point(12, 268);
            groupBoxOperation.Name = "groupBoxOperation";
            groupBoxOperation.Padding = new System.Windows.Forms.Padding(10, 3, 10, 9);
            groupBoxOperation.Size = new System.Drawing.Size(150, 58);
            groupBoxOperation.TabIndex = 0;
            groupBoxOperation.TabStop = false;
            groupBoxOperation.Text = "操作";
            // 
            // emptyButton
            // 
            this.emptyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.emptyButton.Location = new System.Drawing.Point(75, 21);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(65, 28);
            this.emptyButton.TabIndex = 2;
            this.emptyButton.Text = "清空";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // executingButton
            // 
            this.executingButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.executingButton.Location = new System.Drawing.Point(10, 21);
            this.executingButton.Name = "executingButton";
            this.executingButton.Size = new System.Drawing.Size(65, 28);
            this.executingButton.TabIndex = 0;
            this.executingButton.Text = "骰点";
            this.executingButton.UseVisualStyleBackColor = false;
            this.executingButton.Click += new System.EventHandler(this.ExecutingButton_Click);
            // 
            // attributesDisplay
            // 
            attributesDisplay.Controls.Add(this.checkIfSumOnly);
            attributesDisplay.Controls.Add(this.checkIfAddValue);
            attributesDisplay.Location = new System.Drawing.Point(12, 187);
            attributesDisplay.Name = "attributesDisplay";
            attributesDisplay.Size = new System.Drawing.Size(147, 75);
            attributesDisplay.TabIndex = 4;
            attributesDisplay.TabStop = false;
            attributesDisplay.Text = "属性";
            // 
            // checkIfSumOnly
            // 
            this.checkIfSumOnly.AutoSize = true;
            this.checkIfSumOnly.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIfSumOnly.Location = new System.Drawing.Point(3, 40);
            this.checkIfSumOnly.Name = "checkIfSumOnly";
            this.checkIfSumOnly.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.checkIfSumOnly.Size = new System.Drawing.Size(141, 24);
            this.checkIfSumOnly.TabIndex = 1;
            this.checkIfSumOnly.Text = "求和";
            this.checkIfSumOnly.UseVisualStyleBackColor = true;
            this.checkIfSumOnly.CheckedChanged += new System.EventHandler(this.CheckIfSumOnly_CheckedChanged);
            // 
            // checkIfAddValue
            // 
            this.checkIfAddValue.AutoSize = true;
            this.checkIfAddValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIfAddValue.Location = new System.Drawing.Point(3, 21);
            this.checkIfAddValue.Name = "checkIfAddValue";
            this.checkIfAddValue.Size = new System.Drawing.Size(141, 19);
            this.checkIfAddValue.TabIndex = 0;
            this.checkIfAddValue.Text = "添加固定值";
            this.checkIfAddValue.UseVisualStyleBackColor = true;
            this.checkIfAddValue.CheckedChanged += new System.EventHandler(this.CheckIfAddValue_CheckedChanged);
            // 
            // commandDisplay
            // 
            commandDisplay.Controls.Add(this.command);
            commandDisplay.Location = new System.Drawing.Point(12, 338);
            commandDisplay.Name = "commandDisplay";
            commandDisplay.Size = new System.Drawing.Size(258, 68);
            commandDisplay.TabIndex = 101;
            commandDisplay.TabStop = false;
            commandDisplay.Text = "命令行";
            // 
            // command
            // 
            this.command.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.command.Location = new System.Drawing.Point(7, 25);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(245, 25);
            this.command.TabIndex = 0;
            this.command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Command_KeyPress);
            // 
            // rollingValueDisplay
            // 
            this.rollingValueDisplay.Controls.Add(this.rollingValue);
            this.rollingValueDisplay.Location = new System.Drawing.Point(12, 119);
            this.rollingValueDisplay.Name = "rollingValueDisplay";
            this.rollingValueDisplay.Padding = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.rollingValueDisplay.Size = new System.Drawing.Size(58, 62);
            this.rollingValueDisplay.TabIndex = 2;
            this.rollingValueDisplay.TabStop = false;
            this.rollingValueDisplay.Text = "范围";
            // 
            // rollingValue
            // 
            this.rollingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingValue.Location = new System.Drawing.Point(10, 23);
            this.rollingValue.MaxLength = 3;
            this.rollingValue.Name = "rollingValue";
            this.rollingValue.Size = new System.Drawing.Size(38, 25);
            this.rollingValue.TabIndex = 0;
            this.rollingValue.Text = "100";
            this.rollingValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rollingValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RollingValue_KeyPress);
            this.rollingValue.Leave += new System.EventHandler(this.RollingValue_Leave);
            // 
            // rollingResultDisplay
            // 
            this.rollingResultDisplay.Controls.Add(this.rollingResult);
            this.rollingResultDisplay.Location = new System.Drawing.Point(12, 12);
            this.rollingResultDisplay.Name = "rollingResultDisplay";
            this.rollingResultDisplay.Padding = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.rollingResultDisplay.Size = new System.Drawing.Size(150, 100);
            this.rollingResultDisplay.TabIndex = 1;
            this.rollingResultDisplay.TabStop = false;
            this.rollingResultDisplay.Text = "范围：";
            // 
            // rollingResult
            // 
            this.rollingResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingResult.Font = new System.Drawing.Font("黑体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rollingResult.Location = new System.Drawing.Point(3, 21);
            this.rollingResult.Name = "rollingResult";
            this.rollingResult.Size = new System.Drawing.Size(144, 67);
            this.rollingResult.TabIndex = 0;
            this.rollingResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.ItemHeight = 15;
            this.resultsList.Location = new System.Drawing.Point(169, 13);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(101, 319);
            this.resultsList.TabIndex = 100;
            this.resultsList.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 418);
            this.Controls.Add(commandDisplay);
            this.Controls.Add(attributesDisplay);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(groupBoxOperation);
            this.Controls.Add(rollingCountDisplay);
            this.Controls.Add(this.rollingValueDisplay);
            this.Controls.Add(this.rollingResultDisplay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RollingTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            rollingCountDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rollingCount)).EndInit();
            groupBoxOperation.ResumeLayout(false);
            attributesDisplay.ResumeLayout(false);
            attributesDisplay.PerformLayout();
            commandDisplay.ResumeLayout(false);
            commandDisplay.PerformLayout();
            this.rollingValueDisplay.ResumeLayout(false);
            this.rollingValueDisplay.PerformLayout();
            this.rollingResultDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rollingResultDisplay;
        private System.Windows.Forms.Label rollingResult;
        private System.Windows.Forms.TextBox rollingValue;
        private System.Windows.Forms.NumericUpDown rollingCount;
        private System.Windows.Forms.CheckBox checkIfAddValue;
        private System.Windows.Forms.Button emptyButton;
        private System.Windows.Forms.Button executingButton;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.GroupBox rollingValueDisplay;
        private System.Windows.Forms.CheckBox checkIfSumOnly;
        private System.Windows.Forms.TextBox command;
    }
}

