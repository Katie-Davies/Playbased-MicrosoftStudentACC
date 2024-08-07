import { Outlet, useLocation } from 'react-router-dom'
import Nav from '../components/Nav'

function Layout() {
  const location = useLocation()
  console.log(location)
  return (
    <>
      <div>
        <main className="main mb-20">
          {/* {location.pathname !== '/' ? <Nav /> : null} */}
          <Nav />
          <Outlet />
        </main>
        <footer className="mt-auto fixed bottom-0 left-0 z-20 w-full p-4 bg-white">
          <p className="ml-10 text-customGreen">© Bright Beginnings ltd 2024</p>
        </footer>
      </div>
    </>
  )
}

export default Layout
