import GirlPaint from '../assets/girlpaint.jpg'
import FavouriteButton from '../components/FavouriteButton'

const data = {
  name: 'Chalk Painting',
  image: GirlPaint,
  Description:
    'Mix water, cornFlower and food coloring to make chalk paint. Use paint brushes to paint the sidewalk.',
  Materials: ['Water', 'CornFlower', 'Food Coloring', 'Paint Brushes'],
  Duration: '30 minutes',
  Age: ['0-1', '1-2', '2-3', '3-4', '4+'],
}

function ActivityInformation() {
  return (
    <>
      <div className=" flex justify-center flex-wrap content-center  ">
        <div className="bg-customGreen rounded-2xl h-auto  max-h-md max-w-md w-64 md:w-1/3 flex justify-center mx-10 flex-col">
          <img
            src={data.image}
            alt="girl Painting"
            className="m-5 rounded-2xl"
          />
        </div>
        <div className=" justify-center flex-col max-w-96 flex flex-wrap content-center text-center ">
          <div className="flex justify-center">
            <h1 className="text-6xl text-customGreen font-sueEllen m-3 pt-5 pb-5">
              {data.name}
            </h1>
            <FavouriteButton />
          </div>
          <h1 className="font-bold text-xl">Materials:</h1>
          <p className="m-3"> {data.Materials.join(', ')}</p>
          <h1 className="font-bold text-xl">Instructions:</h1>
          <p className="m-3"> {data.Description}</p>
          <h1 className="font-bold text-xl">Age:</h1>
          <p className="m-3">{data.Age.join(', ')}</p>
        </div>
      </div>
    </>
  )
}

export default ActivityInformation
