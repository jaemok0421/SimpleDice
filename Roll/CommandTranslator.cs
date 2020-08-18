using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll
{
    static class CommandTranslator
    {
        /// <summary>
        /// 解释命令行内容并返回骰点结果
        /// </summary>
        /// <param name="cmd">命令行内容</param>
        public static List<int> GetResults(string cmd)
        {
            return TranslateRollingCommands(cmd);
        }

        /// <summary>
        /// 解释骰点命令内容并返回骰点结果。形如1d3+2+……
        /// </summary>
        /// <param name="cmd">骰点命令内容</param>
        private static List<int> TranslateRollingCommands(string cmd)
        {
            List<int> results = new List<int>();
            string[] cmds;

            // 检查字符串中是否有加号，如有则分割
            int index = cmd.IndexOf('+');
            if (index > -1)
                cmds = cmd.Split('+');
            else
            {
                cmds = new string[1];
                cmds[0] = cmd;
            }

            // 对于每个单独命令，进行骰点或直接添加
            try
            {
                for (int i = 0; i < cmds.Length; ++i)
                {
                    results.AddRange(TranslateSingleRollingCommand(cmds[i]));
                }
                return results;
            }
            catch
            {
                throw new FormatException("命令行格式错误");
            }
        }

        /// <summary>
        /// 解释单个骰点命令内容并返回骰点结果。形如1d3或2等
        /// </summary>
        /// <param name="cmd">骰点命令内容</param>
        private static List<int> TranslateSingleRollingCommand(string cmd)
        {
            RollingManager rollingManager = RollingManager.GetInstance();
            List<int> results = new List<int>();
            // 存储初始骰点范围，避免产生预期外的影响
            uint initRollingRange = rollingManager.RollingRange;
            try
            {
                int index = cmd.IndexOf('d');
                if (index > -1)
                {
                    String[] numsStr = cmd.Split('d');
                    if (numsStr.Length != 2 || numsStr[0] == "" || numsStr[1] == "")
                        // 分割字符串不为2个，或有值为空时抛出异常
                        throw new FormatException();

                    // 第一个值为骰点个数
                    int num = Convert.ToInt32(numsStr[0]);
                    // 第二个值为骰点范围
                    uint range = Convert.ToUInt32(numsStr[1]);

                    // 按照获得值进行骰点
                    rollingManager.RollingRange = range;
                    int[] rollingResults = rollingManager.GetRollingResult(num);

                    results.AddRange(rollingResults);
                }
                else
                {
                    // 当命令行内容为常数时，直接添加结果
                    results.Add(Convert.ToInt32(cmd));
                }
                return results;
            }
            catch
            {
                // 为可能出现的异常抛格式错误异常
                throw new FormatException("命令行格式错误");
            }
            finally
            {
                // 恢复初始骰点范围
                rollingManager.RollingRange = initRollingRange;
            }
        }
    }
}
