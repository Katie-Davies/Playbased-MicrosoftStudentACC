import { Outlet } from 'react-router-dom'
import Landing from './Landing'

function App() {
  // const location = useLocation()
  return (
    <>
      <div>
        {/* <header>{location.pathname !== '/' ? 'Home' : 'not home'}</header> */}
        <main className="main">
          <Landing />
          <Outlet />
        </main>
        <footer className="mt-auto">
          <p className="ml-10 text-green-800">Bright Beginnings ltd 2024</p>
        </footer>
      </div>
    </>
  )
}

export default App
