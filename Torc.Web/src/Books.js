import React, { useState } from 'react';
import axios from "axios";

function Books() {
  const [searchTerm, setSearchTerm] = useState('');
  const [searchCategory, setSearchCategory] = useState('');
  const [searchResults, setSearchResults] = useState([]);

  const handleSearch = (e) => {
    e.preventDefault();
    // Perform search operation (for demonstration, let's just set some dummy data)

    const url = 'http://localhost:5260/books/get-books';

    if (searchCategory) {
      url += `?${searchCategory}=${searchTerm}`
    }

    axios.get(url).then((response) => {
      setSearchResults(response.data);
    });
  };

  return (
    <div>
      <form onSubmit={handleSearch}>
        <input
          type="text"
          value={searchTerm}
          onChange={(e) => setSearchTerm(e.target.value)}
          placeholder="Enter your search term"
        />
        <select value={searchCategory} onChange={(e) => setSearchCategory(e.target.value)}>
          <option value="">Select Category</option>
          <option value="Title">Title</option>
          <option value="Type">Type</option>
          <option value="ISBN">ISBN</option>
          <option value="Author">Author</option>
          <option value="Publisher">Publisher</option>
          <option value="Category">Category</option>
        </select>
        <button type="submit">Search</button>
      </form>

      <div>
        <h2>Search Results</h2>
        <table>
          <thead>
            <tr>
              <th>Book Title</th>
              <th>Publisher</th>
              <th>Author</th>
              <th>Type</th>
              <th>ISBN</th>
              <th>Category</th>
              <th>Available Copies</th>
            </tr>
          </thead>
          <tbody>
            {searchResults.map(result => (
              <tr key={result.Id}>
                <td>{result.Title}</td>
                <td>{result.Publisher}</td>
                <td>{result.Author}</td>
                <td>{result.Type}</td>
                <td>{result.ISBN}</td>
                <td>{result.Category}</td>
                <td>`${result.TotalCopies} \ ${result.CopiesInUse}`</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default Books;