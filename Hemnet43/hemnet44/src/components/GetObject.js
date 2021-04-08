import React, { useState, useEffect } from "react";

const url = `http://localhost:60627/api/Objekts`;
const GetObject = () => {
  const [categoryState, setCategoryState] = useState([]);

  useEffect(() => {
    fetch(url).then((res) =>
      res.json().then((data) => {
        setCategoryState(data);
      })
    );
  }, []);

  return (
    <div>
      <ul>
        {categoryState.map((e) => (
          <li>Address:{e.adress}</li>
        ))}
      </ul>
    </div>
  );
};

export default GetObject;
