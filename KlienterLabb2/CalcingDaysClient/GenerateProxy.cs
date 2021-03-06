﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="Calculate days", ConfigurationName="ICalcDaysOld")]
public interface ICalcDaysOld
{
    
    [System.ServiceModel.OperationContractAttribute(Action="Calculate days/ICalcDaysOld/daysOld", ReplyAction="Calculate days/ICalcDaysOld/daysOldResponse")]
    int daysOld(System.DateTime bornDate);
    
    [System.ServiceModel.OperationContractAttribute(Action="Calculate days/ICalcDaysOld/daysOld", ReplyAction="Calculate days/ICalcDaysOld/daysOldResponse")]
    System.Threading.Tasks.Task<int> daysOldAsync(System.DateTime bornDate);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalcDaysOldChannel : ICalcDaysOld, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalcDaysOldClient : System.ServiceModel.ClientBase<ICalcDaysOld>, ICalcDaysOld
{
    
    public CalcDaysOldClient()
    {
    }
    
    public CalcDaysOldClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalcDaysOldClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalcDaysOldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalcDaysOldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int daysOld(System.DateTime bornDate)
    {
        return base.Channel.daysOld(bornDate);
    }
    
    public System.Threading.Tasks.Task<int> daysOldAsync(System.DateTime bornDate)
    {
        return base.Channel.daysOldAsync(bornDate);
    }
}
