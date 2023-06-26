using RoosterBoard.Data.Models.Space;

namespace RoosterBoard.Services.Space
{
    public class AgentService
    {
        private Spacer? _activeSpacer;
        private string _spacerToken = string.Empty;

        public void SetSpacer(Spacer spacer, string token)
        {
            _activeSpacer = spacer;
            _spacerToken = token;
        }

        public Spacer? FetchActiveSpacer => _activeSpacer;

        public string FetchToken() => _spacerToken;
    }
}
