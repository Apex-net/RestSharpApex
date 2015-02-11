using System;

namespace RestSharpApex.Authenticators.OAuth
{
#if !SILVERLIGHT && !WINDOWS_PHONE
	[Serializable]
#endif
	internal enum HttpPostParameterType
	{
		Field,
		File
	}
}