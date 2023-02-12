import React, { useEffect, useState } from 'react';
import { Card } from 'antd';
import { AntDesignOutlined } from '@ant-design/icons';
import { Avatar } from 'antd';
import { Descriptions } from 'antd';


const { Meta } = Card;


function About() {

  const search = window.location.search;
  const params = new URLSearchParams(search);
  const id = params.get('id');

  // hooks
  const [breed, setBreed] = useState([]);
  const [data, setData] = useState([]);

  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'application/json',
          'x-api-key' : 'live_sae8Gf9mH4ZPtjuUUstRLdThlSyEH5mtH7EqH5jbnFDEud2OCChpkHTNE42ffPce'
        },
    };

    fetch ("https://api.thedogapi.com/v1/breeds/"+id, requestOptions)
     .then(response => response.json())
     .then(breed=>setBreed(breed));
  }, []);


  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'application/json',
          'x-api-key' : 'live_sae8Gf9mH4ZPtjuUUstRLdThlSyEH5mtH7EqH5jbnFDEud2OCChpkHTNE42ffPce'
        },
    };
  
    fetch ("https://api.thedogapi.com/v1/images/search?format=json&breed_id="+id, requestOptions)
     .then(response => response.json())
     .then(data=>setData(data));
  }, []);

  console.log(breed);

  return (
    <>
        <Avatar
          size={{
            xs: 24,
            sm: 32,
            md: 40,
            lg: 64,
            xl: 80,
            xxl: 300,
          }}
          shape="square"
          icon={<AntDesignOutlined />}
          src={ data[0]?.url }
          style={{ display:'flex',flexWrap:'wrap', justifyContent:'center', alignContent:'center' }}
        />
        <Descriptions style={{margin:'50px'}} title="Собака Info">
            <Descriptions.Item label="Порода">{ breed.name }</Descriptions.Item>
            <Descriptions.Item label="Вес">{ breed?.weight?.imperial !== undefined ? breed.weight.imperial : "Данные отсутсвуют" }</Descriptions.Item> 
            <Descriptions.Item label="Размер">{ breed?.height?.imperial !== undefined ? breed.height.imperial : "Данные отсутсвуют"}</Descriptions.Item>
            <Descriptions.Item label="Время жизни">{ breed.life_span }</Descriptions.Item>
        </Descriptions>
    </>
  );
}

export default About;
