using ODTGUI.ApplicationModels.Enums;
using ODTGUI.Utils;
using System;
using System.IO;

namespace ODTGUI.DAL
{
    public class Repository<T> where T: class
    {
        //default working directory
        private string _repositoryPath;

        private ILogger _logger;

        /// <summary>
        /// Init repository
        /// </summary>
        /// <param name="logger">your logger to log actions in repository</param>
        /// <param name="path">your path to get and store data</param>
        public Repository(ILogger logger, string path = "")
        {
            _logger = logger;
            if(path == string.Empty)
            {
                path = AppDomain.CurrentDomain.BaseDirectory;
            }
            _repositoryPath = $@"{Path.GetDirectoryName(path)}\";

            _logger.Log($"Repository init done at {path}", LogLevel.Info);
        }


    }
}
