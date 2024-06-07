using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlxSerialTerminal
{
    internal class CmdMgr
    {
        MainForm _mainForm;
        public CmdMgr(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public string  processCmd(string sText)
        {
            string sCmd = "@clear";
            if (sText.IndexOf(sCmd) != -1)
            {
                return processCmd_clear(sText);
            }

            return sText;
        }

        string  processCmd_clear(string sText)
        {
            string sPattern = "@clear";
            _mainForm.clearScreen();
            string sText2ret = sText.Substring(sText.IndexOf(sPattern) + sPattern.Length).TrimStart();
            return sText2ret;
        }


    }
}
