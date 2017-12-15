using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODTGUI.DAL
{
    public class Repository
    {
        //default working directory
        private string _repositoryPath;
        /// <summary>
        /// Init repository with storage path C:\Storage\
        /// </summary>
        /// <param name="path"></param>
        public Repository(string path = "")
        {
            if(path == string.Empty)
            {
                path = AppDomain.CurrentDomain.BaseDirectory;
            }
            _repositoryPath = $@"{Path.GetDirectoryName(path)}\";
        }


    }
}
