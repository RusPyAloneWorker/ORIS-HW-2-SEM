import { Pagination } from 'antd';

const Page = ({page, count, length, paginate}) =>     
  <Pagination onChange={(page, pageSize) => paginate(page, pageSize)} 
        defaultPageSize={count} 
        defaultCurrent={page} 
        total={length} 
        style={{ paddingTop:"50px",   margin:"auto" }} />;

  export default Page;