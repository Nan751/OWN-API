import React, { useState } from 'react';
import axios from 'axios';
import './Movie.css';


function Movie() {
  const [data, setData] = useState({})
  const [movie, setMovies] = useState('')

  
  const url = `https://localhost:7176/api/Movie/Getmovie?Movienames=${movie}`
  


  const searchMovie = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
    }
  }
  return (
    <div className="app">
    
      <div className="search">
        <input
          value={movie}
           onChange={event => setMovies(event.target.value)}
          onKeyPress={searchMovie}
          placeholder='Enter Movies Name !!'
          type="text" 
          />
      </div>

      <div className="container">
        <div className="top">
          <div className="mov1">           
            <p>{data.title}-{data.year}</p>
            
          </div>
          
          <div >
           <p><img id="img1"src={data.images}alt={data.title}/></p>
          </div>
          </div> 
        </div>
        </div>

        

    
  );
}
export default Movie;