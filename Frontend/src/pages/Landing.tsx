import { getAllUsers } from '../apis/apiClient'
import girlPainting from '../assets/girlpaint.jpg'
import logo from '../assets/Logo500x500.png'
import Button from '../components/Button'
import { useNavigate } from 'react-router-dom'

function Landing() {
  const navigate = useNavigate()

  function handleClick() {
    navigate('/activities')
  }

  const users = getAllUsers()
  console.log('this is being called', users)

  return (
    <div className="grid grid-cols-1 md:grid-cols-3 gap-4 place-items-center">
      <img
        src={girlPainting}
        alt="Little girl covered in paint"
        className="w-2/3 md:w-full h-auto sm:h-auto md:h-screen col-span-1 hidden md:block"
      />

      <div className="col-span-1 md:col-span-2 text-center md:text-left">
        <div className="flex flex-col justify-center content-center flex-wrap h-screen items-center">
          <img
            src={logo}
            alt="Bright Beginnings Logo"
            className="w-1/2 h-auto  "
          />
          <h1 className="text-center font-sueEllen text-6xl md:text-8xl text-customGreen mb-3">
            Learn Create Play
          </h1>
          <Button className="w-1/3" onClick={handleClick}>
            Explore
          </Button>
        </div>
      </div>
    </div>
  )
}

export default Landing
