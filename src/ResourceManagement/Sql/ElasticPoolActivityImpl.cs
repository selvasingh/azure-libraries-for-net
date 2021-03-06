// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using System;

    /// <summary>
    /// Implementation for Elastic Pool Activity interface.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnNxbC5pbXBsZW1lbnRhdGlvbi5FbGFzdGljUG9vbEFjdGl2aXR5SW1wbA==
    internal partial class ElasticPoolActivityImpl  :
        Wrapper<Models.ElasticPoolActivity>,
        IElasticPoolActivity
    {
        private ResourceId resourceId;

        ///GENMHASH:B045F78FBBD13C1DFD9AB3659442B01B:95FDB4476A86D2D89C844159139FF9F4
        public ElasticPoolActivityImpl(ElasticPoolActivity innerObject) : base(innerObject)
        {
            this.resourceId = ResourceId.FromString(this.Inner.Id);
        }

        ///GENMHASH:957BA7B4E61C9B91983ED17E2B61DBD7:9549FCCFE13908133153A6585989F147
        public string ElasticPoolName()
        {
            return this.Inner.ElasticPoolName;
        }

        ///GENMHASH:BC0F13DCAA6BEA91A858090726A3C218:4403254F1C7FA43AF6FBE6BF7B773A65
        public int RequestedDatabaseDtuGuarantee()
        {
            return this.Inner.RequestedDatabaseDtuGuarantee.GetValueOrDefault();
        }

        ///GENMHASH:FA2CBCD1D0B27E5D168FBB43CC86517C:A0A5B3AF0643F29A7053E5BEE8C9882A
        public int ErrorSeverity()
        {
            return this.Inner.ErrorSeverity.GetValueOrDefault();
        }

        ///GENMHASH:6CEDF49FFA73F9F5E2F923E4726F2EFA:DCD9AD663CBDFACD6E94C20AED2FD63A
        public int ErrorCode()
        {
            return this.Inner.ErrorCode.GetValueOrDefault();
        }

        ///GENMHASH:20676CF3647D516CBCCD0807065BACB9:55F0618BF6BD745C131C2BBD910CE4A0
        public string ServerName()
        {
            return this.Inner.ServerName;
        }

        ///GENMHASH:2AE7995B57A28F8A97DF524DFDF27CD2:C8226E4D59A7CACB7879B25945055290
        public long RequestedStorageLimitInMB()
        {
            return this.Inner.RequestedStorageLimitInMB.GetValueOrDefault();
        }

        ///GENMHASH:579156BC87293AD83F70BBF347CFEF47:8ACA8E03B61F5FC45CB2DFEE3F51696A
        public long RequestedStorageLimitInGB()
        {
            return this.Inner.RequestedStorageLimitInGB.GetValueOrDefault();
        }

        ///GENMHASH:7EF3D853483A47D9B9984C075548A5DB:740F056656F4A0D00BEAED4AA4FBF109
        public int RequestedDatabaseDtuMax()
        {
            return this.Inner.RequestedDatabaseDtuMax.GetValueOrDefault();
        }

        ///GENMHASH:03526126BC38B1E6BD9561737558EC5D:1175667EA7EC5F56E7E123B5FF22F500
        public string OperationId()
        {
            return this.Inner.OperationId.ToString();
        }

        ///GENMHASH:8550B4F26F41D82222F735D9324AEB6D:42AE1A0453935D9BF88147F2F9C3EC20
        public DateTime? StartTime()
        {
            return this.Inner.StartTime;
        }

        ///GENMHASH:ACA2D5620579D8158A29586CA1FF4BC6:003E1843567E7760DFADC015F30E6AF4
        public string Id()
        {
            return this.Inner.Id;
        }

        ///GENMHASH:AEE17FD09F624712647F5EBCEC141EA5:F31B0F3D0CD1A4C57DB28EB70C9E094A
        public string State()
        {
            return this.Inner.State;
        }

        ///GENMHASH:E9EDBD2E8DC2C547D1386A58778AA6B9:9FE42D967416923E070F823D07063A47
        public string ResourceGroupName()
        {
            return this.resourceId.ResourceGroupName;
        }

        ///GENMHASH:90D0D26360B526D44FA6BF00B58572D2:6D05B62EB1B97540267134991BAE6456
        public int RequestedDtuGuarantee()
        {
            return this.Inner.RequestedDtuGuarantee.GetValueOrDefault();
        }

        ///GENMHASH:8F0EFF0AACCEFD64C58E15E16D3EC64E:337753FAB2FD3F556E28B3B41F66A995
        public int RequestedDatabaseDtuMin()
        {
            return this.Inner.RequestedDatabaseDtuMin.GetValueOrDefault();
        }

        ///GENMHASH:7EC64CE674517E507F9E7D72F93A7DF6:83C9FF1F82052A9E5127DEA47990F4A0
        public string ErrorMessage()
        {
            return this.Inner.ErrorMessage;
        }

        ///GENMHASH:64FDD7DAC0F2CAB9406652DA7545E8AA:3F5BF88EAEB847CE67B8C16A5FDD2D28
        public int PercentComplete()
        {
            return this.Inner.PercentComplete.GetValueOrDefault();
        }

        ///GENMHASH:7E31FD4694B88FC2F9C1EE28D77055ED:EDE1E4292DB486E168AE4CFE8282FCA2
        public int RequestedDtu()
        {
            return this.Inner.RequestedDtu.GetValueOrDefault();
        }

        ///GENMHASH:1C96DDC2D75E02C621FE6D4174D08795:A5C5C3EE08E59E95C0BE7571AEFDDAD8
        public string RequestedElasticPoolName()
        {
            return this.Inner.RequestedElasticPoolName;
        }

        ///GENMHASH:3E38805ED0E7BA3CAEE31311D032A21C:A08302619254C2A4BBCEC7165449AD96
        public string Name()
        {
            return this.resourceId.Name;
        }

        ///GENMHASH:AA663B484486518EBB36248DF424F238:D9CF33DCD9E57CC41ABB700C8430D4B6
        public int RequestedDatabaseDtuCap()
        {
            return this.Inner.RequestedDatabaseDtuCap.GetValueOrDefault();
        }

        ///GENMHASH:A85BBC58BA3B783F90EB92B75BD97D51:3054A3D10ED7865B89395E7C007419C9
        public string Location()
        {
            return this.Inner.Location;
        }

        ///GENMHASH:3C1909F3137E91E93C57B90768BECD1A:561DFB636B157F511DFC1C40D1BDE39E
        public DateTime? EndTime()
        {
            return this.Inner.EndTime;
        }

        ///GENMHASH:01229D1464D8E021DA051A6483890125:1E5595F4838189B1321C43E5E3F05009
        public string Operation()
        {
            return this.Inner.Operation;
        }
    }
}