function testForNull(ourNumber)
{
  if(isNaN(ourNumber))
  {
    return(0);
  }
  else
    return(ourNumber);
}

//////////////////////////////////////////////////////////////////////////////////////

function getItemID(item, tier, enchant, city, quality) 
{
  //Setup initial variables
  var webAdress = "https://www.albion-online-data.com/api/v2/stats/prices/";
  var itemIdentifier = "";
  var itemSpecs = "";


  //Set the item identifier Tier
  itemIdentifier = "T" + tier + "_" + item;
  //Add the item ID and enchant to the web adress
  if(enchant == 0)
  {
    webAdress = webAdress + itemIdentifier + ".xml"
  }
  else if(enchant == 1||2||3)
  {
    webAdress = webAdress + itemIdentifier + "@" + enchant + ".xml"
  }


  //Add the initial query to the adress
  itemSpecs = "?" + "locations=" + city + "&" + "qualities=" + quality;
  //Add item specs to the web adress
  webAdress = webAdress + itemSpecs;


  //Output
  return(webAdress);
}

/////////////////////////////////////////////////////////////////////////////////////////

function getItemQuery(transaction)
{
  //Setup initial variables
  var xQuery = "//ArrayOfMarketResponse/MarketResponse";
  //Determine transaction type
  switch(transaction)
  {
    case "Buy":
      xQuery = "//ArrayOfMarketResponse/MarketResponse/BuyPriceMax";
    break;
    case "Sell":
      xQuery = "//ArrayOfMarketResponse/MarketResponse/SellPriceMin";
    break;
  }


  //Output
  return(xQuery);
}

////////////////////////////////////////////////////////////////////////////////////////////

function highestPrice(pSterling, pCaerleon, pMartlock, pBridgewatch, pThetford, pLymhurst) 
{
  arrPrices=[
      pSterling, 
      pCaerleon, 
      pMartlock, 
      pBridgewatch, 
      pThetford, 
      pLymhurst]
      var highestPrice = 0;
  for(var i=0; i<7; i++)
  {
    if(arrPrices[i]>highestPrice)
    {
      highestPrice=arrPrices[i];
    }
  }
    return(highestPrice);
}