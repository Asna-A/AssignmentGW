var user=[
    {
      "FirstName": "John",
      "LastName": "Doe",
      "Age": 20,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Jane",
      "LastName": "Smith",
      "Age": 22,
      "Department": "Physics"
    },
    {
      "FirstName": "Michael",
      "LastName": "Johnson",
      "Age": 21, 
      "Department": "Mathematics"
    },
    {
      "FirstName": "Sarah",
      "LastName": "Williams",
      "Age": 19,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Robert",
      "LastName": "Brown",
      "Age": 23,
      "Department": "Mathematics"
    },
    {
      "FirstName": "Emily",
      "LastName": "Davis",
      "Age": 20,
      "Department": "Computer Science"
    }
  ]
  
// List the students whose department is computer science.
var computer_science_Students=user.filter(x=>x.Department==="Computer Science").map(x=>x.FirstName+ " "+x.LastName)
console.log("computer scinece students: "+computer_science_Students)

//List the first name of students whose age is greater than  21
var age_greater_than_21=user.filter(x=>x.Age>21).map(x=>x.FirstName)
console.log("age_greater_than_21: "+age_greater_than_21)

//Check whether a student having a first name as Robert is present in the Computer Science Department. The result should be in boolean type
var Robert_cs=user.some(x=>x.FirstName==="Robert" && x.Department==="Computer Science")
console.log(Robert_cs)

//Check whether there is any student whose age is greater than 23 is studying in the Maths department.The result should be in boolean type
var maths_23=user.some(x=>x.Age>23 && x.Department==="Mathematics")
console.log(maths_23)

//Check whether all the students are above an age group of 18.The result should be in boolean type.
var age_greater_than_18=user.every(x=>x.Age>18)
console.log(age_greater_than_18)

//Assuming that there is only one student having a first name as John, Print his department name
var find_john=user.find(x=>x.FirstName==="John")
console.log(find_john.Department)

var movie=[
    {
      "MovieName": "The Great Adventure",
      "ActorName": "John Smith",
      "ReleaseDate": "2023-01-15"
    },
    {
      "MovieName": "Mystery in the Woods",
      "ActorName": "Emily Johnson",
      "ReleaseDate": "2022-09-28"
    },
    {
      "MovieName": "Love and Destiny",
      "ActorName": "Michael Brown",
      "ReleaseDate": "2023-05-02"
    },
    {
      "MovieName": "City of Shadows",
      "ActorName": "Sophia Williams",
      "ReleaseDate": "2023-03-12"
    },
    {
      "MovieName": "The Last Stand",
      "ActorName": "William Davis",
      "ReleaseDate": "2022-11-07"
    },
    {
      "MovieName": "Echoes of Time",
      "ActorName": "Olivia Wilson",
      "ReleaseDate": "2022-12-19"
    }
  ]
   
//List the movie name along with the actor name of those movies released in the year 2022
var movie_2022=movie.filter(x=>new Date(x.ReleaseDate).getFullYear()===2022).map(x=>({Movie:x.MovieName,Actor:x.ActorName}))
console.log(movie_2022)

//List the movie names released in the year 2023 where the actor is William Davis.
var movie_2023_William_Davis=movie.filter(x=>new Date(x.ReleaseDate).getFullYear()===2023 && x.ActorName==="William Davis").map(x=>x.MovieName)
console.log(movie_2023_William_Davis)

//Retrieve the Actor name and release date of the movie “The Last Stand”
var The_Last_Stand=movie.filter(x=>x.MovieName==="The Last Stand").map(x=>({Actor:x.ActorName,ReleaseDate:x.ReleaseDate}))
console.log(The_Last_Stand)

//Check whether there is any movie in the list with actor name “John Doe”
var movie_of_John=movie.some(x=>x.ActorName==="John Doe")
console.log(movie_of_John)

//Display the count of movies where the actor name is "Sophia Williams"
var count_of_movies=movie.filter(x=>x.ActorName==="Sophia Williams").length
console.log(count_of_movies)

//Insert an element
//     {
//             "MovieName": "The Final Stage",
//             "ActorName": "John Doe",
//             "ReleaseDate": "2022-08-11"
//       }
// as last element
var new_element={
 "MovieName": "The Final Stage",
 "ActorName": "John Doe",
 "ReleaseDate": "2022-08-11" 
}
movie.push(new_element)
console.log(movie)

//Check whether there exists any duplicate movie names present in the array
var movie_Set=new Set();
movie.forEach(item=>{
    
        movie_Set.add(item.MovieName)
    
    }
)
if(movie.length!=movie_Set.size)
{
    console.log("duplicate element exist")
}
else
{
    console.log("duplicate element doesn't exist")
}

//Create a new array starting from the movie "City of Shadows"
var start_index=movie.findIndex(x=>x.MovieName==="City of Shadows")
var new_movie_list=movie.slice(start_index)
console.log(new_movie_list)

//List the distinct actor names in array
var distinct_actor_names=new Set()
movie.forEach(item=>{
    distinct_actor_names.add(item.ActorName)
})
console.log(distinct_actor_names)

// Insert an element
//     {
//             "MovieName": "Rich & Poor",
//             "ActorName": "Johnie Walker",
//             "ReleaseDate": "2023-08-11"
//       }
// as next element to movie “Love and Destiny”
var index=movie.findIndex(x=>x.MovieName==="Love and Destiny")
movie.splice(index+1,0,{
                "MovieName": "Rich & Poor",
                "ActorName": "Johnie Walker",
                 "ReleaseDate": "2023-08-11"
           })
console.log(movie)

// Display the count of distinct actor names in array
var count_actor=distinct_actor_names.size
console.log(count_actor)

// Remove the movie named  "The Last Stand"
var index=movie.findIndex(x=>x.MovieName==="The Last Stand")
movie.splice(index,1)
console.log(movie)

// Check whether all the movies are released after 2021 Dec 31
var check_release=movie.every(x=>x.ReleaseDate>new Date('2021-12-31'))
console.log(check_release)

// Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"
movie.forEach(item=>{
    if(item.MovieName==="City of Shadows")
    {
        item.ReleaseDate="2023-03-13"
    }
})
console.log(movie)

// Create a new array of movie names whose movie name length is greater than 10.
var movies_length_great10=[];
movie.forEach(item=>{
    if(item.MovieName.length>10){
        movies_length_great10.push(item.MovieName)
    }
})
console.log(movies_length_great10)
