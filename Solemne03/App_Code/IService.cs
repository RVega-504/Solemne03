using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
    [OperationContract]
    float calcularModulo(Factor factor);
}

[DataContract]
public class Factor
{
	float a, b;

    [DataMember]
    public float A
    {
        get
        {
            return a;
        }

        set
        {
            a = value;
        }
    }

    [DataMember]
    public float B
    {
        get
        {
            return b;
        }

        set
        {
            b = value;
        }
    }
}
