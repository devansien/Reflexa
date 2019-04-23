namespace Reflexa
{
    class PageBuilder : Core
    {
        public static void SetMainPage(string utterance)
        {
            if (Echo.IsRound)
            {
                SpotMainPage spotMainPage = new SpotMainPage();
                Response.SetDirectives(DirectiveHelper.GetRenderDirective(SessionKey.SpotAplToken, "Scroll to see more recordings.", spotMainPage.GetSpotMainPage(utterance)));
            }
            else
            {
                ShowMainPage showMainPage = new ShowMainPage();
                Response.SetDirectives(DirectiveHelper.GetRenderDirective(SessionKey.ShowAplToken, "Scroll to see more recordings.", showMainPage.GetShowMainPage(utterance)));
            }
        }
    }
}
