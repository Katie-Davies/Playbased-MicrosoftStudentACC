import { Outlet, useLocation } from 'react-router-dom'
import Nav from '../components/Nav'

function Layout() {
  const location = useLocation()
  console.log(location)
  return (
    <>
      <div>
        {/* <header>{location.pathname !== '/' ? 'Home' : 'not home'}</header> */}
        <main className="main">
          {location.pathname !== '/' ? <Nav /> : null}
          <Outlet />
        </main>
        <footer className="mt-auto">
          <p className="ml-10 text-green-800">Bright Beginnings ltd 2024</p>
        </footer>
      </div>
    </>
  )
}

export default Layout
