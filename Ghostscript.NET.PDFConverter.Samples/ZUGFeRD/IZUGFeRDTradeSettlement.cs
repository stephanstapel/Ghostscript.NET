namespace Ghostscript.NET.PDFA3Converter.Samples.ZUGFeRD
{
	public interface IZUGFeRDTradeSettlement
	{

		/// <summary>
		///*
		/// </summary>
		/// <returns> zf2 xml for applicableHeaderTradeSettlement </returns>
		string getSettlementXML();


		/// <summary>
		///*
		/// </summary>
		/// <returns> zf2 xml for applicableHeaderTradePayment </returns>
		string getPaymentXML()
		{
			return null;
		}



	}
}
