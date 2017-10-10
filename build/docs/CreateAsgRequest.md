---
title: CreateAsgRequest
---
## ININ.PureCloudApi.Model.CreateAsgRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **AsgOwnerEmail** | **string** | Email address of the individual starting the ASG | |
| **EdgeGroupId** | **string** | Edge group that the user wants the asg edges to be assigned to. | [optional] |
| **ExternalTrunkBaseId** | **string** | Trunk base that the user wants the asg edges to be assigned to | [optional] |
| **AsgLogicalIAMInstanceProfile** | **string** | Overrides the default logical IAM Instance Profile | [optional] |
| **AsgAmi** | **bool?** | Overrides the default EDGE AMI used with the ASG | [optional] |
| **AsgType** | **string** | Overrides the type of ASG being created.  By default we always create a &#39;standard&#39; asg. | [optional] |
| **AsgInstanceCount** | **int?** | Overrides the default number of Edge instances to start in the ASG | [optional] |
| **AsgNetworkSpace** | **string** | Overrides the network space the ASG will start in.  The default will always be mediaservices | [optional] |
| **AsgChaosExempt** | **bool?** | Optional parameter that exempts this ASG from chaos monkey killing one of its instances. | [optional] |
| **AsgRecoveryShutdownMinutes** | **int?** | Number of minutes a recovery ASG will stay active before it is torn down | [optional] |
{: class="table table-striped"}


