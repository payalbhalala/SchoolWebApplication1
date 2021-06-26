# SchoolWebApplication1
# ERD Daigram ![ERD](https://user-images.githubusercontent.com/65688803/123496837-1f612d00-d5f8-11eb-8f30-48116939f5d4.jpeg)

# Data Dictionaries
Data Item/<br>Field Name|Data Type|Data Format|Number of Bytes per Storage|Size of display|Description|Example|
| :- | :- | :- | :- | :- | :- | :- |
|User ID|String|XXNNNN|6|6|Unique Identifier for User|PB1234|
|Username|Varchar||25|25|Full Name of user|Payal Bhalala|
|Password|VarChar|XXXXXNNS|15|8|Password for the User to login for the enrolled Course|Qwert12^|
|Email|String||60|30|Email Id of the user|Kbb1@njit.edu|
|Status|Boolean|X|1|1|<p>Enrolled(y) or</p><p>Not enrolled(N)</p>|Y|
|System Role ID|String|XNNN||4|System ID based on role If student or teacher|T123|
|Created Date|Floating Point<br>(Date Format)|DD/MM/YYYY|4|10|Date when Course created for user|03/21/1995|
|Updated date|Floating Point<br>(Date Format|DD/MM/YYYY|4|10|Date when course is being updated|03/21/1995|
