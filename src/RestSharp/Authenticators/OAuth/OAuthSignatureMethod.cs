using System;

namespace RestSharpApex.Authenticators.OAuth
{
#if !SILVERLIGHT && !WINDOWS_PHONE
	[Serializable]
#endif
	public enum OAuthSignatureMethod
	{
		HmacSha1,
		PlainText,
		RsaSha1
	}
}