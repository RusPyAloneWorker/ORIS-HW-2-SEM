import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { Card} from 'antd';


const { Meta } = Card;


function Dogs() {

  // hooks
  const [data, setData] = useState([]);

  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'application/json',
          'x-api-key' : 'live_sae8Gf9mH4ZPtjuUUstRLdThlSyEH5mtH7EqH5jbnFDEud2OCChpkHTNE42ffPce'
        },
    };
  
    fetch ("https://api.thedogapi.com/v1/images/search?format=json&limit=10&order=ASC&has_breeds=1", requestOptions)
     .then(response => response.json())
     .then(data=>setData(data));
  }, []);

  console.log(data);

  return (
    <>
        { data.map ((item) => (
            <Link to={  '/dog?id=' + (item.breeds[0]?.id !== undefined ? item.breeds[0]?.id : 0)  } key={item.id}>
                <Card
                      key={ item.id }
                      hoverable
                      style={{
                        width: 240, 
                        marginBottom: '25px',
                        textDecoration:'none'
                      }}
                      cover={<img alt="example" src={ item.url } />}>
                    <Meta title={ item.breeds[0]?.name } description="попугаи лучше" />
                </Card>
            </Link>
          )
        )}
    </>
  );
}

export default Dogs;
