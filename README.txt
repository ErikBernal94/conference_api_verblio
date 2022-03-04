README

Build and run
------------------------------------------------------

The solution must be build and run with .NET core, it can be done opening the solution using visual studio or 
using the comands 'dotnet build' and 'dotnet run' on the project path.

For more information: https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run

-------------------------------------------------------

Use

-------------------------------------------------------

The app stores the data into an in-memory database, for the reason the data is deleated in each run.

-------------------------------------------------------

Add a talk:

POST
URL: http://localhost:5000/api/Talks/
Body:
  {
    "title": "CILLUM NON",
    "abstract": "Aliqua consequat mollit Lorem dolor nulla qui sunt tempor veniam eiusmod ullamco quis commodo.",
    "room": 873,
    "speaker": {
      "name": "Hendrix Carroll",
      "company": "Songlines",
      "email": "hendrixcarroll@songlines.com",
      "bio": "Magna velit adipisicing ullamco sint duis nisi."
    },
    "attendees": [
      {
        "name": "Sanders Riley",
        "company": "Comtext",
        "email": "sandersriley@comtext.com",
        "registered": "2015-05-24T02:15:04 +07:00"
      },
      {
        "name": "Bean Cline",
        "company": "Utarian",
        "email": "beancline@utarian.com",
        "registered": "2015-06-21T02:54:39 +07:00"
      },
      {
        "name": "Alfreda Mitchell",
        "company": "Dreamia",
        "email": "alfredamitchell@dreamia.com",
        "registered": "2015-09-22T06:35:29 +07:00"
      }
    ]
  }

Response 

200 ok - Talk inserted with id: {id}

---------------------------------------------------------------

Get all the talks:
GET
URL: http://localhost:5000/api/Talks/
Response:

200 ok 
[
    {
        "id": 1,
        "title": "CILLUM NON",
        "abstract": "Aliqua consequat mollit Lorem dolor nulla qui sunt tempor veniam eiusmod ullamco quis commodo.",
        "room": "873",
        "speaker": {
            "id": 1,
            "name": "Hendrix Carroll",
            "company": "Songlines",
            "email": "hendrixcarroll@songlines.com",
            "bio": "Magna velit adipisicing ullamco sint duis nisi.",
            "idTalk": 1
        },
        "attendees": [
            {
                "id": 1,
                "name": "Sanders Riley",
                "company": "Comtext",
                "email": "sandersriley@comtext.com",
                "registered": "2015-05-24T02:15:04 +07:00",
                "idTalk": 1
            },
            {
                "id": 2,
                "name": "Bean Cline",
                "company": "Utarian",
                "email": "beancline@utarian.com",
                "registered": "2015-06-21T02:54:39 +07:00",
                "idTalk": 1
            },
            {
                "id": 3,
                "name": "Alfreda Mitchell",
                "company": "Dreamia",
                "email": "alfredamitchell@dreamia.com",
                "registered": "2015-09-22T06:35:29 +07:00",
                "idTalk": 1
            }
        ]
    }
]
---------------------------------------------------------------

Remove a talk:
DELETE
URL: http://localhost:5000/api/Talks/{id}
Response: 
200 ok 
Talk with id: {id}, deleted

----------------------------------------------------------------

Add an attendee:

POST
URL: http://localhost:5000/api/Attendees
Body: 
  {
	"name": "Sanders Riley",
	"company": "Comtext",
	"email": "sandersriley@comtext.com",
	"registered": "2015-05-24T02:15:04 +07:00"
  }
  
Response:
200 ok Attendee inserted with id: {id}
---------------------------------------------------------------
Add an attendee to a talk:

POST
URL: http://localhost:5000/api/Attendees/{idTalk}
Body: 
  {
	"name": "Sanders Riley",
	"company": "Comtext",
	"email": "sandersriley@comtext.com",
	"registered": "2015-05-24T02:15:04 +07:00"
  }
  
Response:
200 ok Attendee inserted
---------------------------------------------------------------

Get all the attendees

GET
URL: URL: http://localhost:5000/api/Attendees
Response:

200 ok

[
    {
        "id": 1,
        "name": "Sanders Riley",
        "company": "Comtext",
        "email": "sandersriley@comtext.com",
        "registered": "2015-05-24T02:15:04 +07:00",
        "talk": null,
        "idTalk": 1
    },
    {
        "id": 2,
        "name": "Bean Cline",
        "company": "Utarian",
        "email": "beancline@utarian.com",
        "registered": "2015-06-21T02:54:39 +07:00",
        "talk": null,
        "idTalk": 1
    },
    {
        "id": 3,
        "name": "Alfreda Mitchell",
        "company": "Dreamia",
        "email": "alfredamitchell@dreamia.com",
        "registered": "2015-09-22T06:35:29 +07:00",
        "talk": null,
        "idTalk": 1
    },
    {
        "id": 4,
        "name": "Sanders Riley",
        "company": "Comtext",
        "email": "sandersriley@comtext.com",
        "registered": "2015-05-24T02:15:04 +07:00",
        "talk": null,
        "idTalk": 0
    }
]

