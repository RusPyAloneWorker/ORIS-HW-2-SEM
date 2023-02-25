import React, { useEffect, useState } from 'react';
import Page from './Pagination';
import items from './ItemsBreed';
import { DownOutlined } from '@ant-design/icons';
import { Dropdown, Space, Typography } from 'antd';
import { Pagination, Input, Row, Col, Button } from 'antd';
import { Link } from 'react-router-dom';
import { Card } from 'antd';


const { Meta } = Card;

function Dogs() {

  // states
  const [length, setLength] = useState(500);
  const [count, setCount] = useState(10);
  const [page, setPage] = useState(1);
  const [data, setData] = useState([]);

  const [heightT, setHT] = useState(999);
  const [heightF, setHF] = useState(0);
  const [weightT, setWT] = useState(999);
  const [weightF, setWF] = useState(0);
  const [ageT, setAT] = useState(999);
  const [ageF, setAF] = useState(0);




  var urlCountFetch = `http://localhost:5041/api/Dog/Count/params?breed=${""}&heightFrom=${heightF}` +
    `&heightTo=${heightT}&weightFrom=${weightF}&weightTo=${weightT}&ageFrom=${ageF}&ageTo=${ageT}`;
  var urlDataFetch = `http://localhost:5041/api/Dog/${page}/${count}/params?breed=${""}&heightFrom=${heightF}` +
    `&heightTo=${heightT}&weightFrom=${weightF}&weightTo=${weightT}&ageFrom=${ageF}&ageTo=${ageT}`;

  // console.log(data);
  // console.log(urlCountFetch);
  // console.log(urlDataFetch);
  // console.log(length);

  useEffect(() => {
    const requestOptions = {
      method: "GET",
      headers: { "Content-Type": 'text/json' },
    };

    fetch(urlCountFetch, requestOptions)
      .then(response => response.json())
      .then(data => setLength(data));
  }, [length]);


  useEffect(() => {
    const requestOptions = {
      method: "GET",
      headers: { "Content-Type": 'text/json' },
    };

    fetch(urlDataFetch, requestOptions)
      .then(response => response.json())
      .then(data => setData(data));
  }, []);

  var loadData = (_page, _count) => {
    setCount(_count);
    setPage(_page);

    console.log(page);
    console.log(count);
    console.log(urlDataFetch);

    fetch(
      `http://localhost:5041/api/Dog/${_page}/${_count}/params?breed=${""}&heightFrom=${heightF}` +
      `&heightTo=${heightT}&weightFrom=${weightF}&weightTo=${weightT}&ageFrom=${ageF}&ageTo=${ageT}`
    )
      .then(response => response.json())
      .then(data => setData(data));
  }

  var load = (_page, _count) => {
    setCount(_count);
    setPage(_page);

    console.log(page);
    console.log(count);
    console.log(urlDataFetch);

    fetch(
      `http://localhost:5041/api/Dog/${_page}/${_count}/params?breed=${""}&heightFrom=${heightF}` +
      `&heightTo=${heightT}&weightFrom=${weightF}&weightTo=${weightT}&ageFrom=${ageF}&ageTo=${ageT}`
    )
      .then(response => response.json())
      .then(data => setData(data));

    fetch(
      `http://localhost:5041/api/Dog/Count/params?breed=${""}&heightFrom=${heightF}` +
      `&heightTo=${heightT}&weightFrom=${weightF}&weightTo=${weightT}&ageFrom=${ageF}&ageTo=${ageT}`
    )
      .then(response => response.json())
      .then(data => setLength(data));
  }

  return (
    <div style={{ display: "flex", flexWrap: "wrap", flexDirection: "column" }}>
      <div style={{ marginBottom: "50px", margin: "auto" }}>
        {data.map((item) => (
          <Link to={'/dog?id=' + (item.id !== undefined ? item.id : 0)} key={item.id}>
            <Card
              key={item.id}
              hoverable
              style={{
                width: 240,
                marginBottom: '25px',
                textDecoration: 'none'
              }}
              cover={<img alt="example" src={item.imgUrl} />}>
              <Meta title={item.name} description={item.description} />
            </Card>
          </Link>
        )
        )}
      </div>

      <Page page={page} size={count} length={length} paginate={loadData} />

      <div style={{ margin: "auto", paddingTop: "50px", paddingBottom: "50px", paddingLeft: "200px" }}>
        <Input.Group size="large" className='Age' style={{ marginTop: '50px' }}>
          <div>Максимальный возраст (от, до)</div>
          <Row gutter={8}>
            <Col span={5}>
              <Input type='number' defaultValue={ageF} title="от" onChange={(e) => { setAF(parseInt(e.target.value)) }} />
            </Col>
            <Col span={8} title="до">
              <Input type='number' defaultValue={ageT} onChange={(e) => { setAT(parseInt(e.target.value)) }} />
            </Col>
          </Row>
        </Input.Group >

        <Input.Group size="large" className='Height' style={{ marginTop: '50px' }}>
          <div>Максимальный Рост (от, до)</div>
          <Row gutter={8}>
            <Col span={5}>
              <Input type='number' defaultValue={heightF} title="от" onChange={(e) => setHF(parseInt(e.target.value))} />
            </Col>
            <Col span={8} title="до">
              <Input type='number' defaultValue={heightT} onChange={(e) => { setHT(parseInt(e.target.value)) }} />
            </Col>
          </Row>
        </Input.Group >
        <Input.Group size="large" className='Weight' style={{ marginTop: '50px' }}>
          <div>Максимальный вес (от, до)</div>
          <Row gutter={8}>
            <Col span={5}>
              <Input type='number' defaultValue={weightF} title="от" onChange={(e) => setWF(parseInt(e.target.value))} />
            </Col>
            <Col span={8} title="до">
              <Input type='number' defaultValue={weightT} onChange={(e) => setWT(parseInt(e.target.value))} />
            </Col>
          </Row>
        </Input.Group >


        <div style={{ marginTop:'50px', marginLeft:'80px' }}>
          <Dropdown
            onSelect={(e)=>console.log(e)}
            menu={{
              items,
              selectable: true,
              defaultSelectedKeys: ['3'],
            }}>
            <Typography.Link onSelect={(e)=>console.log(e)} onChange={(e)=> console.log(e)}>
              <Space>
                Порода
                <DownOutlined onSelect={(e)=>console.log(e.value)} onChange={(e)=> console.log(e)}/>
              </Space>
            </Typography.Link>
          </Dropdown>
        </div>
      </div>
      <Button onClick={() => load(page, count)} style={{ marginBottom: '50px', fontWeight: '500' }}>Отфильтровать</Button>
    </div>
  );
}

export default Dogs;
