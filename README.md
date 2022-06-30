# ComputerNetworks_Project
#This project was held by:
    Esra Nur Özüm
    Selin Ağan
    Elif Aydın

Developed a basic social networking application called SUBook (an oversimplified version of Facebook) and implemented client and server modules. 

•	The Server module manages the storage of posts, posts feed, and friendships between the users

•	The Client module acts as a user who shares posts, adds and removes other users from his/her friendship, and views posts of other users.

The server listens on a predefined port and accepts incoming client connections. There might be one or more clients connected to the server at the same time. Each client knows the IP address and the listening port of the server (to be entered through the Graphical User Interface (GUI)). Clients connect to the server on a corresponding port and identify themselves with their usernames. Server needs to keep the usernames of currently connected clients to avoid the same name to be connected more than once at a given time to the server.

On the server side, there is a predefined database of users which are presumed to be registered to the social network so that you do not need to implement any registration process between a client and the server. That user database has been provided as a textual file named user-db.txt. 

In the second phase of the project client and server modules modified to add more functionalities.
The following features are added to the application:

    1. Requesting post feed posted by friends only.
    
    2. Adding and removing friends.
    
    3. Being able to see your friend list.
    
    4. Deleting own posts.


