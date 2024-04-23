

listJson = {
  lineId: 1,
  elements: {}
}

elementList = [];
elementList.push({Id: 1, Top: 100, Left: 100});
listJson["elements"] = elementList;

const serverResponse = fetch(apiURL,
    {
        mode: "cors",
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(listJson),
    }
    )
  .then((response) => response.text())
  .then((user) => {
    return user;
  });

const getResponse = async () => {
  const r = await serverResponse;
  console.log(await serverResponse);
};

getResponse();