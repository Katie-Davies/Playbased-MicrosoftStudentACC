import { Outlet, useLocation } from 'react-router-dom'
import Nav from '../components/Nav'

function Layout() {
  const location = useLocation()
  console.log(location)
  return (
    <>
      <div>
        <main className="main">
          {/* {location.pathname !== '/' ? <Nav /> : null} */}
          <Nav />
          <Outlet />
        </main>
        <footer className="mt-auto fixed bottom-0 left-0 z-20 w-full p-4">
          <p className="ml-10 text-green-800">Bright Beginnings ltd 2024</p>
        </footer>
      </div>
    </>
  )
}

export default Layout
