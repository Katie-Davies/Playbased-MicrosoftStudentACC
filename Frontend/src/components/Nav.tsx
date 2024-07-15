import { Link, useLocation } from 'react-router-dom'
import logo from '../assets/Logo500x500.png'

function Nav() {
  const location = useLocation()
  return (
    <>
      <div className="flex justify-start flex-wrap content-center">
        <img src={logo} alt="logo" className="w-20 h-auto" />
        {location.pathname === '/activities' ? (
          <Link
            to="favourites"
            className="font-sueEllen text-2xl text-customGreen p-3 self-center"
          >
            My Favourites
          </Link>
        ) : location.pathname === '/favourites' ? (
          <Link
            to="activities"
            className="font-sueEllen text-2xl text-customGreen p-3 self-center"
          >
            Activities
          </Link>
        ) : (
          <>
            <Link
              to="activities"
              className="font-sueEllen text-2xl text-customGreen p-3 self-center"
            >
              Activities
            </Link>
            <Link
              to="favourites"
              className="font-sueEllen text-2xl text-customGreen p-3 self-center"
            >
              My Favourites
            </Link>
          </>
        )}
      </div>
    </>
  )
}

export default Nav
