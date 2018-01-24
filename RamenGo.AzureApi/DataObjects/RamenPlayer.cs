using Microsoft.Azure.Mobile.Server;

namespace RamenGo.AzureApi.DataObjects
{
    /// <summary>
    /// Ramen Model
    /// </summary>
    public class RamenPlayer : EntityData
    {
        public string Name { get; set; }

        public int Score { get; set; }
    }
}