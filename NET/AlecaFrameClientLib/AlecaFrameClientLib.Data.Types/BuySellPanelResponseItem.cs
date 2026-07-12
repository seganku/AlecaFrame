using Newtonsoft.Json;

namespace AlecaFrameClientLib.Data.Types;

public class BuySellPanelResponseItem
{
	public string playerName;

	public int platimun;

	public string specialValue = "";

	public int amount;

	public int tradeAmount;

	[JsonIgnore]
	public Order order;

	public BuySellPanelResponseItem(Order order)
	{
		playerName = order.user.ingameName;
		platimun = order.platinum;
		amount = order.quantity;
		tradeAmount = order.perTrade;
		this.order = order;
	}
}
