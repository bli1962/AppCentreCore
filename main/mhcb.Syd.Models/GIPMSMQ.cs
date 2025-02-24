using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
	public enum GIPMSMQ
	{
		SIF = 1,
		BIF = 2,
		SAP = 3,
		FXTransaction = 4,
		FXDelivery = 5,
		RatesSpot = 6,
		RatesRevaluation = 7,
		RatesSwap = 8,
		RatesFunding = 9,
		RatesBIS = 10
	}

	public enum FxDealProcess
	{
		FxTransation = 0,
		FxDelivery = 1
	}

	public enum QueueTypes
	{
		SIF,
		BIF,
		SAP ,
		FXTransaction ,
		FXDelivery ,

		FX_RATE,
		REVALUATION_RATE,
		SWAP_RATE,
		DEPOSITS_RATE,
		BIS_RATE
	}

	public enum RateTypes
	{
        //FX_RATE,
        //REVALUATION_RATE,
        //SWAP_RATE,
        //DEPOSITS_RATE,
        //BIS_RATE

        FX_RATE = 0,
        REVALUATION_RATE = 1,
        SWAP_RATE = 2,
        DEPOSITS_RATE = 3,
        BIS_RATE = 4
    }
}
