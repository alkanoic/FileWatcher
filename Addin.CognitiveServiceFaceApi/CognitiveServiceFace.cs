using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace Addin.CognitiveServiceFaceApi
{
	[Export(typeof(IAddin))]
	public class CognitiveServiceFace : Addin.IAddin
	{
		public string AddinName => "Cognitive Service Face Api";

		public bool HasSetting => true;

		public bool HasCreated => true;

		public bool HasChanged => false;

		public bool HasDeleted => false;

		public bool HasRenamed => false;

		public bool HasError => false;

		public IDictionary<string, string> SettingValues { get => this._settings; set => this._settings = value; }

		private IDictionary<string, string> _settings;

		public ILogger Logger { get; set; }
		public IWatcher Watcher { get; set; }

		public Task ChangedMethodAsync(FileSystemEventArgs e)
		{
			throw new NotImplementedException();
		}

		static byte[] GetImageAsByteArray(string imageFilePath)
		{
			FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			return binaryReader.ReadBytes((int)fileStream.Length);
		}

		public async Task CreatedMethodAsync(FileSystemEventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);

			var client = new HttpClient();

			// Request headers - replace this example key with your valid key.
			//client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", OcpApimSubscriptionKey);
			client.DefaultRequestHeaders.Add(setting.OcpApimSubscriptionKeyValue, setting.OcpApimSubscriptionValue);

			// NOTE: You must use the same region in your REST call as you used to obtain your subscription keys.
			//   For example, if you obtained your subscription keys from westcentralus, replace "westus" in the 
			//   URI below with "westcentralus".
			//string uri = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/recognize?";
			string uri = setting.UriKeyValue;
			HttpResponseMessage response;
			string responseContent;

			// Request body. Try this sample with a locally stored JPEG image.
			byte[] byteData = GetImageAsByteArray(e.FullPath);

			using (var content = new ByteArrayContent(byteData))
			{
				// This example uses content type "application/octet-stream".
				// The other content types you can use are "application/json" and "multipart/form-data".
				//content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
				content.Headers.ContentType = new MediaTypeHeaderValue(setting.MediaTypeHeaderKeyValue);
				response = await client.PostAsync(uri, content);
				//response = await client.PostAsync(uri, content);
				responseContent = response.Content.ReadAsStringAsync().Result;
			}

			//A peak at the JSON response.
			this.Logger.Info(response);
			this.Logger.Info(responseContent);

		}

		public Task DeletedMethodAsync(FileSystemEventArgs e)
		{
			throw new NotImplementedException();
		}

		public Task ErrorMethodAsync(ErrorEventArgs e)
		{
			throw new NotImplementedException();
		}

		public Task RenamedMethodAsync(RenamedEventArgs e)
		{
			throw new NotImplementedException();
		}

		public void ShowSettingForm()
		{
			using (var sf = new SettingForm())
			{
				if (this.SettingValues is null)
				{
					this.SettingValues = new Dictionary<string, string>();
				}
				sf.SettingValues = this.SettingValues;
				sf.ShowDialog();
				this.SettingValues = sf.SettingValues;
			}
		}
	}
}
