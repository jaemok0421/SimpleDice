using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll
{
    public partial class MainForm : Form
    {
        private RollingManager rollingManager;
        private bool isRolling = true;
        private int count = 1;
        private string defaultResultDisplayText;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMainForm();
        }

        /// <summary>
        /// 范围/数值文本框按键事件
        /// </summary>
        private void RollingValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char key = e.KeyChar;
            bool isHandled = true;
            if (char.IsNumber(key))
            {
                // 当按键为数字时可输入
                isHandled = false;
            }
            else
            {
                switch (key)
                {
                    case (char)Keys.Enter:
                        // 输入回车时执行更新函数
                        UpdateRollingValue(Convert.ToUInt32(rollingValue.Text));
                        break;
                    case (char)Keys.Back:
                        // 允许输入退格键
                        isHandled = false;
                        break;
                }
            }
            e.Handled = isHandled;
        }

        /// <summary>
        /// 范围/数值文本框失去焦点事件
        /// </summary>
        private void RollingValue_Leave(object sender, EventArgs e)
        {
            UpdateRollingValue(Convert.ToUInt32(rollingValue.Text));
        }

        /// <summary>
        /// 命令行文本框按键事件
        /// </summary>
        private void Command_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char key = e.KeyChar;
            bool isHandled = true;
            if (char.IsNumber(key))
            {
                // 当按键为数字时可输入
                isHandled = false;
            }
            else
            {
                switch (key)
                {
                    case (char)Keys.Enter:
                        // 输入回车时执行函数
                        ExecuteCommand();
                        break;
                    case 'D':
                        // 允许输入字母D
                    case 'd':
                        // 允许输入字母d
                    case '+':
                        // 允许输入加号键
                    case (char)Keys.Back:
                        // 允许输入退格键
                        isHandled = false;
                        break;
                }
            }
            e.Handled = isHandled;
        }

        /// <summary>
        /// 添加固定值选中状态变化事件
        /// </summary>
        private void CheckIfAddValue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIfAddValue.Checked)
            {
                rollingValueDisplay.Text = "数值";
                rollingValue.Text = "1";
                executingButton.Text = "添加";
                isRolling = false;
            }
            else
            {
                rollingValueDisplay.Text = "范围";
                rollingValue.Text = Convert.ToString(rollingManager.RollingRange);
                executingButton.Text = "骰点";
                isRolling = true;
            }
            rollingCount.Value = 1;
        }

        /// <summary>
        /// 求和选中状态变化事件
        /// </summary>
        private void CheckIfSumOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIfSumOnly.Checked)
            {
                UpdateMultipleResults();
            }
        }

        /// <summary>
        /// 骰点/添加按钮点击事件
        /// </summary>
        private void ExecutingButton_Click(object sender, EventArgs e)
        {
            int[] addList;
            count = Convert.ToInt32(rollingCount.Value);
            if (isRolling)
            {
                addList = Rolling(count);
            }
            else
            {
                addList = new int[count];
                int value = Convert.ToInt32(rollingValue.Text);
                for (int i = 0; i < count; ++i)
                    addList[i] = value;
            }
            AddToResultsList(addList);
        }

        /// <summary>
        /// 清空按钮点击事件
        /// </summary>
        private void EmptyButton_Click(object sender, EventArgs e)
        {
            resultsList.Items.Clear();
            rollingResult.Text = "";
        }

        /// <summary>
        /// 程序初始化
        /// </summary>
        private void InitMainForm()
        {
            // 获取骰点管理器用例
            rollingManager = RollingManager.GetInstance();

            // 锁定窗体大小，不允许改变
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            // 初始化文本内容
            defaultResultDisplayText = rollingResultDisplay.Text;
            RefreshRollingResultDisplayText();
            rollingValue.Text = Convert.ToString(rollingManager.RollingRange);
            rollingCount.Value = count;
        }

        /// <summary>
        /// 执行一次骰点操作
        /// </summary>
        /// <param name="num">骰点次数</param>
        private int[] Rolling(int num)
        {
            return rollingManager.GetRollingResult(num);
        }

        /// <summary>
        /// 添加新内容至结果列表
        /// </summary>
        /// <param name="addList">新内容</param>
        private void AddToResultsList(IEnumerable<int> addList)
        {
            int addListCount = addList.Count<int>();
            for (int i = 0; i < addListCount; ++i)
            {
                resultsList.Items.Add(addList.ElementAt<int>(i).ToString());
            }
            // 更新此次添加结果显示
            if (isRolling && !checkIfSumOnly.Checked && addListCount == 1)
            {
                // 只有一个骰点、且不需求和时，只显示该次骰点内容
                UpdateSingleRollingResult();
            }
            else
            {
                // 其他情况则显示列表骰点及固定值总和
                UpdateMultipleResults();
            }
        }

        /// <summary>
        /// 更新单次骰点结果
        /// </summary>
        private void UpdateSingleRollingResult()
        {
            // 获取结果列表最后一项的值
            uint result = Convert.ToUInt32(resultsList.Items[resultsList.Items.Count - 1].ToString());

            RefreshRollingResultDisplayText();
            RefreshRollingResultText(result);
        }

        /// <summary>
        /// 更新多次骰点（和/或）添加多个固定值结果
        /// </summary>
        private void UpdateMultipleResults()
        {
            int resultsCount = resultsList.Items.Count;
            if (resultsCount > 0)
            {
                uint sum = 0;
                for (int i = 0; i < resultsCount; ++i)
                {
                    sum += Convert.ToUInt32(resultsList.Items[i].ToString());
                }
                RefreshRollingResultDisplayText("数值总和");
                RefreshRollingResultText(sum);
            }
        }

        /// <summary>
        /// 检查并更新数值区域内容
        /// </summary>
        /// <param name="value">更新数值</param>
        private void UpdateRollingValue(uint value)
        {
            if (value != 0)
            {
                if (isRolling)
                {
                    rollingManager.RollingRange = value;
                    RefreshRollingResultDisplayText();
                }
            }
            else
            {
                MessageBox.Show(rollingValueDisplay.Text + "不可为0！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rollingValue.Text = Convert.ToString(rollingManager.RollingRange);
                rollingValue.Focus();
            }
        }

        /// <summary>
        /// 执行命令行内容
        /// </summary>
        private void ExecuteCommand()
        {
            List<int> addList;
            // 暂存骰点模式，因为命令行模式必须求和
            bool cachedIsRolling = isRolling;
            try
            {
                addList = CommandTranslator.GetResults(command.Text);
                isRolling = false;
                resultsList.Items.Clear();
                AddToResultsList(addList);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                isRolling = cachedIsRolling;
            }
        }

        /// <summary>
        /// 刷新骰点显示控件的文本
        /// </summary>
        private void RefreshRollingResultDisplayText()
        {
            RefreshRollingResultDisplayText(defaultResultDisplayText + rollingManager.GetRollingRangeStr());
        }

        /// <summary>
        /// 刷新骰点显示控件的文本
        /// </summary>
        /// <param name="newText">更新文本内容</param>
        private void RefreshRollingResultDisplayText(string newText)
        {
            rollingResultDisplay.Text = newText;
        }

        /// <summary>
        /// 刷新骰点显示结果
        /// </summary>
        /// <param name="value">骰点结果</param>
        private void RefreshRollingResultText(uint value)
        {
            rollingResult.Text = value.ToString();
        }
    }
}
