# Finbourne.Scheduler.Sdk.Model.CreateScheduleRequest
Create a schedule definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleId** | [**ResourceId**](ResourceId.md) |  | 
**JobId** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | A display name for this Schedule | 
**Description** | **string** | A description of the Schedule | 
**Author** | **string** | Name of the author of this schedule | [optional] 
**Owner** | **string** | Name of owner of this schedule | [optional] 
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments specified by this Schedule that will be passed in to the Job | [optional] 
**Trigger** | [**Trigger**](Trigger.md) |  | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Schedule | 
**Enabled** | **bool** | Specify whether schedule is enabled or not  Defaults to true | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

