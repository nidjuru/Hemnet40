import React, { useState, useReducer } from "react";
const url = "http://localhost:60627/api/Objekts";

const PostObject = () => {
  //   const [brookerId, setBrookerId] = useState("");

  //     {
  //   "houseId": 0,
  //   "images": "string",
  //   "adress": "string",
  //   "housingType": "string",
  //   "formOfLease": "string",
  //   "price": 0,
  //   "rooms": 0,
  //   "livingArea": 0,
  //   "biArea": 0,
  //   "plotArea": 0,
  //   "descriptions": "string",
  //   "showingDate": "2021-04-08T14:41:46.856Z",
  //   "buildYear": 0,
  //   "brookerId": 0,
  //   "brooker": {
  //     "brookerId": 0,
  //     "firstName": "string",
  //     "lastName": "string",
  //     "email": "string",
  //     "objekts": [
  //       null
  //     ]
  //   }
  // }
  const [images, setImages] = useState("");
  const [adress, setAdress] = useState("");
  const [housingType, setHousingType] = useState("");
  const [formOfLease, setFormOfLease] = useState("");
  const [price, setPrice] = useState(0);
  const [rooms, setRooms] = useState(0);
  const [livingArea, setLivingArea] = useState(0);
  const [biArea, setBiArea] = useState(0);
  const [plotArea, setPlotArea] = useState(0);
  const [descriptions, setDescriptions] = useState("");
  const [showingDate, setShowingDate] = useState("");
  const [buildYear, setBuildYear] = useState(0);

  const SubmitForm = () => {
    const body = {
      images: images,
      adress: adress,
      housingType: housingType,
      formOfLease: formOfLease,
      price: price,
      rooms: rooms,
      livingArea: livingArea,
      biArea: biArea,
      plotArea: plotArea,
      descriptions: descriptions,
      showingDate: showingDate,
      buildYear: buildYear,
      brookerId: 1,
      brooker: null,
    };
    fetch(
      `http://localhost:60627/api/Objekts
`,
      {
        method: "POST",
        headers: { "content-type": "application/JSON" },
        body: JSON.stringify(body),
      }
    ).then((res) =>
      res.json().then((data) => {
        setImages("");
        setAdress("");
        setHousingType("");
        setFormOfLease("");
        setPrice(0);
        setRooms(0);
        setLivingArea(0);
        setBiArea(0);
        setPlotArea(0);
        setDescriptions("");
        setShowingDate("");
        setBuildYear(0);
      })
    );
  };

  return (
    <div>
      {/* <form> */}
      <input
        type="text"
        placeholder="images"
        value={images}
        onChange={(event) => setImages(event.target.value)}
      />
      <input
        type="text"
        placeholder="adress"
        value={adress}
        onChange={(event) => setAdress(event.target.value)}
      />
      <input
        type="text"
        placeholder="housingType"
        value={housingType}
        onChange={(event) => setHousingType(event.target.value)}
      />
      <input
        type="text"
        placeholder="formofLease"
        value={formOfLease}
        onChange={(event) => setFormOfLease(event.target.value)}
      />
      <input
        type="number"
        placeholder="prices"
        value={price}
        onChange={(event) => setPrice(event.target.value)}
      />
      <input
        type="number"
        placeholder="rooms"
        value={rooms}
        onChange={(event) => setRooms(event.target.value)}
      />
      <input
        type="number"
        placeholder="livingArea"
        value={livingArea}
        onChange={(event) => setLivingArea(event.target.value)}
      />
      <input
        type="number"
        placeholder="biArea"
        value={biArea}
        onChange={(event) => setBiArea(event.target.value)}
      />
      <input
        type="number"
        placeholder="plotArea"
        value={plotArea}
        onChange={(event) => setPlotArea(event.target.value)}
      />
      <textarea
        type="text"
        placeholder="descriptions"
        value={descriptions}
        onChange={(event) => setDescriptions(event.target.value)}
      />
      <input
        type="date"
        placeholder="showingDate"
        value={showingDate}
        onChange={(event) => setShowingDate(event.target.value)}
      />
      <input
        type="number"
        placeholder="buildYear"
        value={buildYear}
        onChange={(event) => setBuildYear(event.target.value)}
      />
      <button onClick={() => SubmitForm()}>Submit</button>
      {/* </form> */}
    </div>
  );
};

export default PostObject;
