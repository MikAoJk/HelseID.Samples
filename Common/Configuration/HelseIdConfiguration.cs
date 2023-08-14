namespace HelseId.Samples.Common.Configuration;

/// <summary>
/// This class contains configurations that correspond to clients in HelseID.
/// </summary>
public class HelseIdConfiguration
{
    public HelseIdConfiguration(
        SecurityKey rsaPrivateKeyJwk,
        string clientId,
        string scope,
        string stsUrl,
        bool useDPoP,
        List<string>? resourceIndicators = null)
    {
        RsaPrivateKeyJwk = rsaPrivateKeyJwk;
        ClientId = clientId;
        Scope = scope;
        StsUrl = stsUrl;
        UseDPoP = useDPoP;
        if (resourceIndicators != null)
        {
            ResourceIndicators = resourceIndicators;
        }
    }
    
    // The private key MUST be properly secured inside the client. 
    // TODO: guidelines
    public SecurityKey RsaPrivateKeyJwk  { get; }

    public string ClientId { get; }
    
    public string Scope { get;  }

    public string StsUrl { get; }

    // These are used for clients that are using resource indicators against the authorization and token endpoints:
    public List<string> ResourceIndicators { get; } = new();
    
    public bool UseDPoP { get; }
}