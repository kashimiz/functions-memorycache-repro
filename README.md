# functions-memorycache-repro

## Instructions

1. F5 solution.
2. In Postman or other tool, send the following request:

```GET http://localhost:7071/api/Function1```

3. Host output should resemble the following:

```diff
# [8/13/2019 10:11:55 PM] Executing HTTP request: {
# [8/13/2019 10:11:55 PM]   "requestId": "db88457a-9355-4cb7-824d-409a061d6686",
# [8/13/2019 10:11:55 PM]   "method": "GET",
# [8/13/2019 10:11:55 PM]   "uri": "/api/Function1"
# [8/13/2019 10:11:55 PM] }
# [8/13/2019 10:11:56 PM] Executing 'Function1' (Reason='This function was programmatically called via the host APIs.', Id=5a07c664-ff0b-4b17-bdc2-d11e7a625271)
# [8/13/2019 10:11:56 PM] C# HTTP trigger function processed a request.
- [8/13/2019 10:11:56 PM] Executed 'Function1' (Failed, Id=5a07c664-ff0b-4b17-bdc2-d11e7a625271)
- [8/13/2019 10:11:56 PM] System.Private.CoreLib: Exception while executing function: Function1. System.Runtime.Caching: System.Runtime.Caching is not supported on this platform.
# [8/13/2019 10:11:58 PM] Executed HTTP request: {
# [8/13/2019 10:11:58 PM]   "requestId": "db88457a-9355-4cb7-824d-409a061d6686",
# [8/13/2019 10:11:58 PM]   "method": "GET",
# [8/13/2019 10:11:58 PM]   "uri": "/api/Function1",
# [8/13/2019 10:11:58 PM]   "identities": [
# [8/13/2019 10:11:58 PM]     {
# [8/13/2019 10:11:58 PM]       "type": "WebJobsAuthLevel",
# [8/13/2019 10:11:58 PM]       "level": "Admin"
# [8/13/2019 10:11:58 PM]     }
# [8/13/2019 10:11:58 PM]   ],
# [8/13/2019 10:11:58 PM]   "status": 500,
# [8/13/2019 10:11:58 PM]   "duration": 2226
# [8/13/2019 10:11:58 PM] }
```