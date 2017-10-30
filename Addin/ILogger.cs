using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addin
{
	public interface ILogger
	{
		void Info(string info);

		void Warn(string warn);

		void Error(string error);

		void Fatal(string fatal);

		void Info(Exception ex);

		void Warn(Exception ex);

		void Error(Exception ex);

		void Fatal(Exception ex);

		void Info(object info);

		void Warn(object warn);

		void Error(object error);

		void Fatal(object fatal);

	}
}
