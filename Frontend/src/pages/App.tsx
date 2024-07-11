import { Outlet } from 'react-router-dom'

function App() {
  // const location = useLocation()
  return (
    <>
      <div className="app flex flex-col min-h-screen">
        {/* <header>{location.pathname !== '/' ? 'Home' : 'not home'}</header> */}
        <main className="main">
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
