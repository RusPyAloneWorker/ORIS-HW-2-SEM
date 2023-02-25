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
  var d = 1;

  const [data, setData] = useState([]);

  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'text/json' },
    };
  
    fetch ("http://localhost:5041/api/dog/"+id, requestOptions)
     .then(response => response.json())
     .then(data=>setData(data));
  }, []);

  console.log(data);

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
          src={ data.imgUrl }
          style={{ display:'flex',flexWrap:'wrap', justifyContent:'center', alignContent:'center' }}
        />
        <Descriptions style={{margin:'50px'}} title="Кошка Info">
            <Descriptions.Item label="Порода">{ data.name }</Descriptions.Item>
            <Descriptions.Item label="Макс. Вес">{ data.maxWeight }</Descriptions.Item> 
            <Descriptions.Item label="Мин. Вес">{ data.minWeight }</Descriptions.Item> 
            <Descriptions.Item label="Макс. Рост">{ data.maxHeight }</Descriptions.Item>
            <Descriptions.Item label="Мин. Рост">{ data.minHeight }</Descriptions.Item>
            <Descriptions.Item label="Время жизни">{ data.maxAge }</Descriptions.Item>
        </Descriptions>
    </>
  );
}

export default About;

