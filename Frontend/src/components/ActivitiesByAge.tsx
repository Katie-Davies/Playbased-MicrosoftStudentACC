import SmallCard from '../components/smallCard'
import { useGetActivitiesByAge } from '../hooks/useGetActivitiesByAge'
import { Activity } from '../models/models'

function ActivitiesByAge({ selectedId }: { selectedId: number }) {
  const { data: activitiesByAge, isLoading: activitiesByAgeLoading } =
    useGetActivitiesByAge(selectedId)

  if (activitiesByAgeLoading) {
    return <div>Loading...</div>
  }

  return (
    <div className="flex justify-around flex-wrap">
      {activitiesByAge?.map((activity: Activity) => (
        <SmallCard
          key={activity.id}
          title={activity.title}
          description={activity.description}
          ageGroup={activity.ageGroup}
          materials={activity.materials}
          imgurl={activity.imgUrl}
          id={activity.id}
        />
      ))}
    </div>
  )
}

export default ActivitiesByAge
