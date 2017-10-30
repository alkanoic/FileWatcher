using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher.Logger
{
	class LoggerImpl : Addin.ILogger
	{
		private log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public void Error(string error)
		{
			this._logger.Error(error);
		}

		public void Error(Exception ex)
		{
			this._logger.Error(ex);
		}

		public void Error(object error)
		{
			this._logger.Error(error);
		}

		public void Fatal(string fatal)
		{
			this._logger.Fatal(fatal);
		}

		public void Fatal(Exception ex)
		{
			this._logger.Fatal(ex);
		}

		public void Fatal(object fatal)
		{
			this._logger.Fatal(fatal);
		}

		public void Info(string info)
		{
			this._logger.Info(info);
		}

		public void Info(Exception ex)
		{
			this._logger.Info(ex);
		}

		public void Info(object info)
		{
			this._logger.Info(info);
		}

		public void Warn(string warn)
		{
			this._logger.Warn(warn);
		}

		public void Warn(Exception ex)
		{
			this._logger.Warn(ex);
		}

		public void Warn(object warn)
		{
			this._logger.Warn(warn);
		}
	}
}
