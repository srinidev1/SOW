Use SOW
Go

DECLARE @statesjson NVARCHAR(MAX) = N'[  
    { "state" : {
        "name": "Alabama",
        "abbreviation": "AL"
   } },
    { "state" : {
        "name": "Alaska",
        "abbreviation": "AK"
   } },
    { "state" : {
        "name": "American Samoa",
        "abbreviation": "AS"
   } },
    { "state" : {
        "name": "Arizona",
        "abbreviation": "AZ"
   } },
    { "state" : {
        "name": "Arkansas",
        "abbreviation": "AR"
   } },
    { "state" : {
        "name": "California",
        "abbreviation": "CA"
   } },
    { "state" : {
        "name": "Colorado",
        "abbreviation": "CO"
   } },
    { "state" : {
        "name": "Connecticut",
        "abbreviation": "CT"
   } },
    { "state" : {
        "name": "Delaware",
        "abbreviation": "DE"
   } },
    { "state" : {
        "name": "District Of Columbia",
        "abbreviation": "DC"
   } },
    { "state" : {
        "name": "Federated States Of Micronesia",
        "abbreviation": "FM"
   } },
    { "state" : {
        "name": "Florida",
        "abbreviation": "FL"
   } },
    { "state" : {
        "name": "Georgia",
        "abbreviation": "GA"
   } },
    { "state" : {
        "name": "Guam",
        "abbreviation": "GU"
   } },
    { "state" : {
        "name": "Hawaii",
        "abbreviation": "HI"
   } },
    { "state" : {
        "name": "Idaho",
        "abbreviation": "ID"
   } },
    { "state" : {
        "name": "Illinois",
        "abbreviation": "IL"
   } },
    { "state" : {
        "name": "Indiana",
        "abbreviation": "IN"
   } },
    { "state" : {
        "name": "Iowa",
        "abbreviation": "IA"
   } },
    { "state" : {
        "name": "Kansas",
        "abbreviation": "KS"
   } },
    { "state" : {
        "name": "Kentucky",
        "abbreviation": "KY"
   } },
    { "state" : {
        "name": "Louisiana",
        "abbreviation": "LA"
   } },
    { "state" : {
        "name": "Maine",
        "abbreviation": "ME"
   } },
    { "state" : {
        "name": "Marshall Islands",
        "abbreviation": "MH"
   } },
    { "state" : {
        "name": "Maryland",
        "abbreviation": "MD"
   } },
    { "state" : {
        "name": "Massachusetts",
        "abbreviation": "MA"
   } },
    { "state" : {
        "name": "Michigan",
        "abbreviation": "MI"
   } },
    { "state" : {
        "name": "Minnesota",
        "abbreviation": "MN"
   } },
    { "state" : {
        "name": "Mississippi",
        "abbreviation": "MS"
   } },
    { "state" : {
        "name": "Missouri",
        "abbreviation": "MO"
   } },
    { "state" : {
        "name": "Montana",
        "abbreviation": "MT"
   } },
    { "state" : {
        "name": "Nebraska",
        "abbreviation": "NE"
   } },
    { "state" : {
        "name": "Nevada",
        "abbreviation": "NV"
   } },
    { "state" : {
        "name": "New Hampshire",
        "abbreviation": "NH"
   } },
    { "state" : {
        "name": "New Jersey",
        "abbreviation": "NJ"
   } },
    { "state" : {
        "name": "New Mexico",
        "abbreviation": "NM"
   } },
    { "state" : {
        "name": "New York",
        "abbreviation": "NY"
   } },
    { "state" : {
        "name": "North Carolina",
        "abbreviation": "NC"
   } },
    { "state" : {
        "name": "North Dakota",
        "abbreviation": "ND"
   } },
    { "state" : {
        "name": "Northern Mariana Islands",
        "abbreviation": "MP"
   } },
    { "state" : {
        "name": "Ohio",
        "abbreviation": "OH"
   } },
    { "state" : {
        "name": "Oklahoma",
        "abbreviation": "OK"
   } },
    { "state" : {
        "name": "Oregon",
        "abbreviation": "OR"
   } },
    { "state" : {
        "name": "Palau",
        "abbreviation": "PW"
   } },
    { "state" : {
        "name": "Pennsylvania",
        "abbreviation": "PA"
   } },
    { "state" : {
        "name": "Puerto Rico",
        "abbreviation": "PR"
   } },
    { "state" : {
        "name": "Rhode Island",
        "abbreviation": "RI"
   } },
    { "state" : {
        "name": "South Carolina",
        "abbreviation": "SC"
   } },
    { "state" : {
        "name": "South Dakota",
        "abbreviation": "SD"
   } },
    { "state" : {
        "name": "Tennessee",
        "abbreviation": "TN"
   } },
    { "state" : {
        "name": "Texas",
        "abbreviation": "TX"
   } },
    { "state" : {
        "name": "Utah",
        "abbreviation": "UT"
   } },
    { "state" : {
        "name": "Vermont",
        "abbreviation": "VT"
   } },
    { "state" : {
        "name": "Virgin Islands",
        "abbreviation": "VI"
   } },
    { "state" : {
        "name": "Virginia",
        "abbreviation": "VA"
   } },
    { "state" : {
        "name": "Washington",
        "abbreviation": "WA"
   } },
    { "state" : {
        "name": "West Virginia",
        "abbreviation": "WV"
   } },
    { "state" : {
        "name": "Wisconsin",
        "abbreviation": "WI"
   } },
    { 
	  "state" : {
        "name": "Wyoming",
        "abbreviation": "WY"
      } 
    }   
]';
 DECLARE @vCount int;

 SELECT Count(*)
  FROM [SOW].[dbo].[State]
  IF NOT EXISTS (SELECT * FROM [dbo].[State])
  Begin

  INSERT INTO [dbo].[State] 
  SELECT *
FROM OPENJSON ( @statesjson)
WITH ( [State] VARCHAR(2)   '$.state.abbreviation')



 End

