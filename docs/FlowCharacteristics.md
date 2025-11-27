# FlowCharacteristics

## ININ.PureCloudApi.Model.FlowCharacteristics

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ExecutionItems** | **bool?** | Whether to report execution data about individual actions, menus, states, tasks, etc. etc. that ran during execution of the flow. | [optional] |
| **ExecutionInputOutputs** | **bool?** | Whether to report input setting input setting values and output data values for individual execution items above.  For example, if you have FlowExecutionInputOutputs and a Call Data Action ran in a flow, if FlowExecutionItems was enabled you&#39;d see the fact a Call Data Action ran and the output path it took but nothing about which Data Action it ran, the input data sent to it at flow runtime and the data returned from it.  If you enable this characteristic, execution data will contain this additional detail. | [optional] |
| **Communications** | **bool?** | Communications are either audio or digital communications sent to or received from a participant.  An example here would be the initial greeting in an inbound call flow where it plays a greeting message to the participant. | [optional] |
| **EventError** | **bool?** | Whether to report flow error events. | [optional] |
| **EventWarning** | **bool?** | Whether to report flow warning events. | [optional] |
| **EventOther** | **bool?** | Whether to report events other than errors or warnings such as a language change, loop event. | [optional] |
| **Variables** | **bool?** | Whether to report assignment of values to variables in flow execution data. It&#39;s important to remember there is a difference between variable value assignments and output data from an action.  If you have a Call Digital Bot flow action in an Inbound Message flow and there is no variable bound to the Exit Reason output but FlowExecutionInputOutputs is enabled, you will still be able to see the exit reason from the digital bot flow in execution data even though it is not bound to a variable. | [optional] |
| **Names** | **bool?** | This characteristic specifies whether or not name information should be emitted in execution data such as action, task, state or even the flow name itself.  Names are very handy from a readability standpoint but they do take up additional space in flow execution data instances. | [optional] |



_PureCloudPlatform.Client.V2 250.0.0_
